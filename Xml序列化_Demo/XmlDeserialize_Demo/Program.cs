using Newtonsoft.Json;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace XmlDeserialize_Demo
{
    internal class Program
    {
        //XML报文
        const string xml = @"<soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                                <soap:Body>
                                    <ns2:MarkingCheckResponse TestAttr=""演示未匹配的特性"" xmlns:ns2=""http://WebService.sys_admin.keco.qb.com"">
                                        <return>OK</return>
                                        <TestElement>演示未匹配的元素</TestElement>
                                    </ns2:MarkingCheckResponse>
                                </soap:Body>
                            </soap:Envelope>";

        static void Main(string[] args)
        {
            try
            {
                //将XML反序列化为自定义类的实例
                var obj = Hexgen.Utils.XmlHelper.Deserialize<Envelope>(xml);

                #region 打印json

                StringWriter strWriter = new();
                JsonTextWriter jsonWriter = new(strWriter)
                {
                    Formatting = Newtonsoft.Json.Formatting.Indented,
                    Indentation = 4, //缩进字符数
                    IndentChar = ' ' //缩进字符
                };
                JsonSerializer serializer = new();
                serializer.Serialize(jsonWriter, obj);
                string json = strWriter.ToString();

                Console.WriteLine("反序列化成功：");
                Console.WriteLine(json);

                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine("反序列化失败：");
                Console.WriteLine($"Exception：{ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"InnerException：{ex.InnerException}");
                }
            }

            #region 多次发序列化，测试性能，打印耗时

            //Console.WriteLine("");
            //int count = 100;
            //Stopwatch sw = new();
            //sw.Start();
            //for (int i = 0; i < count; i++)
            //{
            //    Hexgen.Utils.XmlHelper.Deserialize<Envelope>(xml);
            //}
            //sw.Stop();
            //Console.WriteLine($"反序列化{count}次共耗时{sw.ElapsedMilliseconds}ms");

            #endregion
        }
    }

    #region 自定义类，需要与XML数据结构匹配

    /* ===== 注意事项 =====
     * 1. 根节点类名与XML中根节点名称不一致时，需要在XmlRoot特性中显式指定根节点名称，或在XmlHelper.Deserialize()方法中传参；
     * 2. 属性名与XML中节点名称不一致时，需要在XmlElement特性中显示指定节点名称；
     * 3. 特殊情况下属性名必须与XML中节点名称保持一致、并且与C#关键字冲突时，可以在属性名前使用@前缀解决，例如“@return”；
     * 4. XML根节点存在命名空间时，需要在根节点类的XmlRoot特性中显式指定命名空间，或在XmlHelper.Deserialize()方法中传参；
     * 5. XML子节点与父节点命名空间不一致时，需要在子节点XmlElement中显式指定命名空间，否则无法解析子节点；
     * */

    [XmlRoot(Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope
    {
        public Body Body { get; set; }
    }

    public class Body
    {
        [XmlElement(Namespace = "http://WebService.sys_admin.keco.qb.com")]
        public MarkingCheckResponse MarkingCheckResponse { get; set; }
    }

    public class MarkingCheckResponse
    {
        [XmlElement("return", Namespace = "")]
        public string Return { get; set; }

        /// <summary>
        /// 捕获所有未指定的元素
        /// </summary>
        [XmlAnyElement]
        public List<XmlElement> UnknownElements { get; set; } = [];

        /// <summary>
        /// 捕获所有未指定的特性
        /// </summary>
        [XmlAnyAttribute]
        public List<XmlAttribute> UnknownAttributes { get; set; } = [];
    }

    #endregion
}
