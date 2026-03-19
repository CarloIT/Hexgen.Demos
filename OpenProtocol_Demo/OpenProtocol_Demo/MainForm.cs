using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WIT.Global;

namespace OpenProtocol_Demo
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// OpenProtocol客户端
        /// </summary>
        OpenProtocolTcpClient OPClient;

        #region Init

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //加载本地缓存的IP&端口，方便调试
            InitServerCache();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OPClient?.Dispose();

            Environment.Exit(0);
        }

        #endregion

        #region OpenProtocol功能操作

        /// <summary>
        /// 连接服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            #region 重置UI状态

            this.pbConnectionState.Image = Properties.Resources.circle_grey;
            this.pbCommunicationState.Image = Properties.Resources.circle_grey;
            this.pbHeartbeat.Image = Properties.Resources.circle_grey;

            Application.DoEvents();

            #endregion

            string ip = this.txtIP.Text.Trim();
            if (string.IsNullOrEmpty(ip))
            {
                MessageBox.Show("请输入正确的IP地址");
                return;
            }
            if (!int.TryParse(this.txtPort.Text.Trim(), out int port))
            {
                MessageBox.Show("请输入正确的端口号");
                return;
            }

            //本地缓存IP&端口，方便调试
            SaveServerCache(ip, port);

            //实例化OpenProtocol客户端
            OPClient = new OpenProtocolTcpClient(ip, port, 2048)
            {
                Name = "测试Demo"
            };

            #region 注册委托事件

            OPClient.ConnectionStateChanged += OPClient_ConnectionStateChanged;
            OPClient.CommunicationStateChanged += OPClient_CommunicationStateChanged;
            OPClient.MsgSent += OPClient_MsgSent;
            OPClient.MsgReceived += OPClient_MsgReceived;
            OPClient.KeepAlived += OPClient_KeepAlived;
            OPClient.LastTighteningResultReceived += OPClient_LastTighteningResultReceived;
            OPClient.TraceCurveReceived += OPClient_TraceCurveReceived;
            OPClient.DataPackageReceived += OPClient_DataPackageReceived;
            OPClient.SpecialErrorHappened += OPClient_SpecialErrorHappened;

            #endregion

            //连接服务器
            if (!OPClient.Connect(out string errMsg))
            {
                MessageBox.Show(errMsg);
            }
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (!OPClient.Disconnect(out string errMsg))
            {
                MessageBox.Show($"断开连接失败：{errMsg}");
            }
        }

        /// <summary>
        /// 建立服务器通信
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommunicationStart_Click(object sender, EventArgs e)
        {
            if (!OPClient.CommunicationStart(out string errMsg))
            {
                MessageBox.Show($"建立服务器通信失败：{errMsg}");
            }
        }

        /// <summary>
        /// 断开服务器通信
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommunicationStop_Click(object sender, EventArgs e)
        {
            if (!OPClient.CommunicationStop(out string errMsg))
            {
                MessageBox.Show($"断开服务器通信失败：{errMsg}");
            }
        }

        /// <summary>
        /// 使能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (!OPClient.Enable(out string errMsg))
            {
                MessageBox.Show($"使能失败：{errMsg}");
            }
        }

        /// <summary>
        /// 去使能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (!OPClient.Disable(out string errMsg))
            {
                MessageBox.Show($"去使能失败：{errMsg}");
            }
        }

        /// <summary>
        /// 订阅最新一次拧紧结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubscribeLastTighteningResult_Click(object sender, EventArgs e)
        {
            if (!OPClient.SubscribeLastTighteningResult(out string errMsg))
            {
                MessageBox.Show($"订阅最新一次拧紧结果失败：{errMsg}");
            }
        }

        /// <summary>
        /// 取消订阅最新一次拧紧结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnsubscribeLastTighteningResult_Click(object sender, EventArgs e)
        {
            if (!OPClient.UnsubscribeLastTighteningResult(out string errMsg))
            {
                MessageBox.Show($"取消最新一次订阅拧紧结果失败：{errMsg}");
            }
        }

        /// <summary>
        /// 订阅最新一次轨迹曲线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubscribeLatestTraceCurve_Click(object sender, EventArgs e)
        {
            List<OpenProtocolTraceType> traceTypes = new List<OpenProtocolTraceType>();
            {
                #region 拼接勾选的轨迹类型

                if (this.cbTorqueTrace.Checked)
                {
                    traceTypes.Add(OpenProtocolTraceType.TorqueTrace);
                }
                if (this.cbAngleTrace.Checked)
                {
                    traceTypes.Add(OpenProtocolTraceType.AngleTrace);
                }
                if (this.cbCurrentTrace.Checked)
                {
                    traceTypes.Add(OpenProtocolTraceType.CurrentTrace);
                }
                if (this.cbGradientTrace.Checked)
                {
                    traceTypes.Add(OpenProtocolTraceType.GradientTrace);
                }
                if (this.cbStrokeTrace.Checked)
                {
                    traceTypes.Add(OpenProtocolTraceType.StrokeTrace);
                }
                if (this.cbForceTrace.Checked)
                {
                    traceTypes.Add(OpenProtocolTraceType.ForceTrace);
                }

                #endregion

                if (traceTypes == null || traceTypes.Count == 0)
                {
                    MessageBox.Show("至少需要订阅一种轨迹曲线");
                    return;
                }
            }

            if (!OPClient.SubscribeLatestTraceCurve(traceTypes, out string errMsg))
            {
                MessageBox.Show($"订阅最新一次轨迹曲线失败：{errMsg}");
            }
            else
            {
                //更新“已订阅的轨迹曲线”复选框状态
                UpdateSubscribedTraceTypes();
            }
        }

        /// <summary>
        /// 取消订阅轨迹曲线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnsubscribeTraceCurve_Click(object sender, EventArgs e)
        {
            List<OpenProtocolTraceType> traceTypes = new List<OpenProtocolTraceType>();
            {
                #region 拼接勾选的轨迹类型

                if (this.cbTorqueTrace.Checked)
                {
                    traceTypes.Add(OpenProtocolTraceType.TorqueTrace);
                }
                if (this.cbAngleTrace.Checked)
                {
                    traceTypes.Add(OpenProtocolTraceType.AngleTrace);
                }
                if (this.cbCurrentTrace.Checked)
                {
                    traceTypes.Add(OpenProtocolTraceType.CurrentTrace);
                }
                if (this.cbGradientTrace.Checked)
                {
                    traceTypes.Add(OpenProtocolTraceType.GradientTrace);
                }
                if (this.cbStrokeTrace.Checked)
                {
                    traceTypes.Add(OpenProtocolTraceType.StrokeTrace);
                }
                if (this.cbForceTrace.Checked)
                {
                    traceTypes.Add(OpenProtocolTraceType.ForceTrace);
                }

                #endregion

                if (traceTypes == null || traceTypes.Count == 0)
                {
                    MessageBox.Show("至少需要订阅一种轨迹曲线");
                    return;
                }
            }

            if (!OPClient.UnsubscribeTraceCurve(traceTypes, out string errMsg))
            {
                MessageBox.Show($"取消订阅轨迹曲线失败：{errMsg}");
            }
            else
            {
                //更新“已订阅的轨迹曲线”复选框状态
                UpdateSubscribedTraceTypes();
            }
        }

        /// <summary>
        /// 更新“已订阅的轨迹曲线”复选框状态
        /// </summary>
        private void UpdateSubscribedTraceTypes()
        {
            this.cbSubscribedAngleTrace.Checked = OPClient.SubscribedTraceTypes.Contains(OpenProtocolTraceType.AngleTrace);
            this.cbSubscribedTorqueTrace.Checked = OPClient.SubscribedTraceTypes.Contains(OpenProtocolTraceType.TorqueTrace);
            this.cbSubscribedCurrentTrace.Checked = OPClient.SubscribedTraceTypes.Contains(OpenProtocolTraceType.CurrentTrace);
            this.cbSubscribedGradientTrace.Checked = OPClient.SubscribedTraceTypes.Contains(OpenProtocolTraceType.GradientTrace);
            this.cbSubscribedStrokeTrace.Checked = OPClient.SubscribedTraceTypes.Contains(OpenProtocolTraceType.StrokeTrace);
            this.cbSubscribedForceTrace.Checked = OPClient.SubscribedTraceTypes.Contains(OpenProtocolTraceType.ForceTrace);
        }

        /// <summary>
        /// 切换拧紧程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPset_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(this.txtPSetID.Text.Trim(), out int psetID))
            {
                MessageBox.Show("程序号请输入正确的数字");
                return;
            }

            if (!OPClient.SelectPset(psetID, out string errMsg))
            {
                MessageBox.Show($"切换拧紧程序失败：{errMsg}");
            }
        }

        /// <summary>
        /// 切换拧紧任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectJob_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(this.txtJobID.Text.Trim(), out int job))
            {
                MessageBox.Show("任务号请输入正确的数字");
                return;
            }

            if (!OPClient.SelectJob(job, out string errMsg))
            {
                MessageBox.Show($"切换拧紧任务失败：{errMsg}");
            }
        }

        /// <summary>
        /// 手动发送一次心跳
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKeepAlive_Click(object sender, EventArgs e)
        {
            if (!OPClient.Heartbeat(out string errMsg))
            {
                MessageBox.Show($"手动发送心跳失败：{errMsg}");
            }
        }

        #endregion

        #region OpenProtocol客户端委托回调

        /// <summary>
        /// 接收到服务器发送的最新一次拧紧结果
        /// </summary>
        /// <param name="opClient">OpenProtocol客户端</param>
        /// <param name="tighteningResult">拧紧结果</param>
        private void OPClient_LastTighteningResultReceived(OpenProtocolTcpClient opClient, OpenProtocolTighteningResult tighteningResult)
        {
            //拼接显示内容
            string content = $@"拧紧ID：{tighteningResult.TighteningID}
扭矩{tighteningResult.TorqueStatusDesc}：{tighteningResult.Torque}{tighteningResult.TorqueValuesUnitDesc}（{tighteningResult.TorqueFinalTarget} of {tighteningResult.TorqueMinLimit}-{tighteningResult.TorqueMaxLimit}）
角度{tighteningResult.AngleStatusDesc}：{tighteningResult.Angle}（{tighteningResult.AngleFianlTarget} of {tighteningResult.AngleMinLimit}-{tighteningResult.AngleMaxLimit}）
拧紧结果：{(tighteningResult.TighteningStatus ? "OK" : "NG")}
程序号：{tighteningResult.PSetID}
任务号：{tighteningResult.JobID}
控制器时间：{tighteningResult.Timestamp:yyyy-MM-dd HH:mm:ss}
控制器名称：{tighteningResult.TorqueControllerName}";

            MessageBox.Show(content, $"拧紧结果 {tighteningResult.Revision} [{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}]", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 接收到服务器发送的轨迹曲线
        /// </summary>
        /// <param name="opClient">OpenProtocol客户端</param>
        /// <param name="traceCurve">轨迹曲线</param>
        private void OPClient_TraceCurveReceived(OpenProtocolTcpClient opClient, OpenProtocolTraceCurve traceCurve)
        {
            /* MessageBox弹窗显示
             
            //拼接显示内容
            string content = $@"拧紧ID：{traceCurve.TighteningID}
控制器时间：{traceCurve.Timestamp:yyyy-MM-dd HH:mm:ss}
数据单位：{traceCurve.UnitDesc}
曲线数据（{traceCurve.NumberOfTraceSamples}）：{string.Join(",", traceCurve.TraceSamples)}";

            MessageBox.Show(content, $"{traceCurve.TraceTypeDesc}曲线 [{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}]", MessageBoxButtons.OK, MessageBoxIcon.Information);

            **/

            //曲线绘制Demo
            new Thread(() =>
            {
                new TraceCurveForm(traceCurve).ShowDialog();
            })
            {
                IsBackground = true
            }.Start();
        }

        /// <summary>
        /// 接收到服务器发送的完整拧紧数据包
        /// </summary>
        /// <param name="opClient"></param>
        /// <param name="dataPackage">拧紧数据包</param>
        private void OPClient_DataPackageReceived(OpenProtocolTcpClient opClient, OpenProtocolTighteningDataPackage dataPackage)
        {
            /* MessageBox弹窗显示
             
            //拼接显示内容
            string content = $@"拧紧ID：{dataPackage.TighteningID}
Json：{Newtonsoft.Json.JsonConvert.SerializeObject(dataPackage)}";

            //TODO --使用echarts自动绘制曲线

            MessageBox.Show(content, $"拧紧数据包 [{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}]", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            **/

            //曲线绘制Demo
            new Thread(() =>
            {
                new TraceCurveForm(dataPackage).ShowDialog();
            })
            {
                IsBackground = true
            }.Start();
        }

        /// <summary>
        /// 连接状态发生变化
        /// </summary>
        /// <param name="opClient">OpenProtocol客户端</param>
        /// <param name="connected">连接状态</param>
        private void OPClient_ConnectionStateChanged(OpenProtocolTcpClient opClient, bool connected)
        {
            this.Invoke(new Action(() =>
            {
                this.pnlFunctions.Enabled = connected;

                this.btnConnect.Enabled = !connected;
                this.btnDisconnect.Enabled = connected;
                this.txtIP.Enabled = !connected;
                this.txtPort.Enabled = !connected;

                this.pbConnectionState.Image = connected ? Properties.Resources.circle_green : Properties.Resources.circle_red;

                if (!connected)
                {
                    this.pbHeartbeat.Image = Properties.Resources.circle_grey;

                    //更新“已订阅的轨迹曲线”复选框状态
                    UpdateSubscribedTraceTypes();
                }

                Application.DoEvents();
            }));

            //自动重连
            //if (!connected)
            //{
            //    opClient.Connect(out _);
            //}
        }

        /// <summary>
        /// 服务器通信状态发生变化
        /// </summary>
        /// <param name="opClient">OpenProtocol客户端</param>
        /// <param name="communicated">服务器通信状态</param>
        private void OPClient_CommunicationStateChanged(OpenProtocolTcpClient opClient, bool communicated)
        {
            this.Invoke(new Action(() =>
            {
                this.btnCommunicationStart.Enabled = !communicated;
                this.btnCommunicationStop.Enabled = communicated;

                this.pbCommunicationState.Image = communicated ? Properties.Resources.circle_green : Properties.Resources.circle_red;

                if (!communicated)
                {
                    this.pbHeartbeat.Image = Properties.Resources.circle_grey;
                }

                Application.DoEvents();
            }));
        }

        /// <summary>
        /// KeepAlive
        /// </summary>
        /// <param name="opClient">OpenProtocol客户端</param>
        /// <param name="flag"></param>
        private void OPClient_KeepAlived(OpenProtocolTcpClient opClient, bool? flag)
        {
            this.Invoke(new Action(() =>
            {
                if (flag == null)
                {
                    this.pbHeartbeat.Image = Properties.Resources.circle_yellow;
                }
                else if ((bool)flag)
                {
                    this.pbHeartbeat.Image = Properties.Resources.circle_green;
                }
                else
                {
                    this.pbHeartbeat.Image = Properties.Resources.circle_red;
                }

                Application.DoEvents();
            }));
        }

        /// <summary>
        /// 向服务器发送了信息
        /// </summary>
        /// <param name="opClient">OpenProtocol客户端</param>
        /// <param name="msg"></param>
        private void OPClient_MsgSent(OpenProtocolTcpClient opClient, OpenProtocolMsg msg)
        {
            this.Invoke(new Action(() =>
            {
                PrintLog(msg, "发送 =>");
            }));
        }

        /// <summary>
        /// 接收到了服务器发送的信息
        /// </summary>
        /// <param name="opClient">OpenProtocol客户端</param>
        /// <param name="msg"></param>
        private void OPClient_MsgReceived(OpenProtocolTcpClient opClient, OpenProtocolMsg msg)
        {
            this.Invoke(new Action(() =>
            {
                PrintLog(msg, "接收 <=");
            }));
        }

        /// <summary>
        /// OpenProtocol客户端发生了特殊错误
        /// </summary>
        /// <param name="opClient"></param>
        /// <param name="errMsg"></param>
        private void OPClient_SpecialErrorHappened(OpenProtocolTcpClient opClient, string errMsg)
        {
            MessageBox.Show($"OpenProtocol客户端[{opClient.Name}]发生了特殊错误：{errMsg}", "特殊错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region 其它辅助功能

        /// <summary>
        /// UI打印日志
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="direction"></param>
        private void PrintLog(OpenProtocolMsg msg, string direction)
        {
            //过滤心跳
            if (!this.cbShowHeartbeat.Checked && msg.MIDType == OpenProtocolMIDType.KeepAlive)
            {
                return;
            }

            this.txtLog.AppendText($"[{msg.Timestamp:HH:mm:ss.fff}] {direction} {msg.MIDType}\r\n");
            this.txtLog.AppendText($"               CMD：{msg.CMD}\r\n");
            string hexStr = string.Join(" ", msg.OriginalBytes.Select(t => string.Format("{0:X2}", t)));
            this.txtLog.AppendText($"               Hex：{hexStr}\r\n");

            Application.DoEvents();
        }

        /// <summary>
        /// 保存日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSaveLog_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "保存本地文件";
                //dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.FileName = $"OpenProtocol报文日志_{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.txt";
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                dialog.FilterIndex = 1;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                    {
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.Write(this.txtLog.Text);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 清空日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiClearLog_Click(object sender, EventArgs e)
        {
            this.txtLog.Clear();
        }

        /// <summary>
        /// 缓存文件路径-最后一次尝试连接的服务器信息
        /// </summary>
        readonly string FilePath_ServerCache = Path.Combine(Application.StartupPath, "server.cache");

        /// <summary>
        /// 加载本地缓存的服务器信息
        /// </summary>
        private void InitServerCache()
        {
            if (File.Exists(FilePath_ServerCache))
            {
                string content = File.ReadAllText(FilePath_ServerCache);
                string[] temp = content.Split(',');
                if (temp.Length > 1)
                {
                    this.txtIP.Text = temp[0];
                    this.txtPort.Text = temp[1];
                }
            }
        }

        /// <summary>
        /// 保存“最后一次尝试连接的服务器信息”
        /// </summary>
        private void SaveServerCache(string ip, int port)
        {
            using (FileStream fs = new FileStream(FilePath_ServerCache, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write($"{ip},{port}");
                }
            }
        }

        #endregion

        /// <summary>
        /// 演示轨迹曲线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowTraceCurve_Click(object sender, EventArgs e)
        {
            //演示数据
            string hexStr = "31 33 32 32 30 39 30 30 30 30 31 20 30 30 30 30 20 20 20 20 30 30 30 30 30 30 34 39 33 34 32 30 32 34 2D 30 38 2D 30 37 3A 31 36 3A 30 30 3A 35 36 30 30 30 30 32 30 31 30 30 31 30 30 36 30 31 30 30 30 30 30 31 30 31 30 30 30 30 30 30 30 38 30 30 30 31 30 30 30 30 30 34 30 30 30 30 30 30 30 30 31 32 30 32 30 30 38 30 34 30 30 30 30 30 30 30 41 34 34 31 31 35 32 34 30 30 30 35 31 30 30 34 30 31 30 30 30 30 30 30 30 34 39 33 34 30 30 30 35 33 30 31 30 30 31 30 30 30 30 30 30 30 31 37 32 33 30 34 36 34 35 36 30 32 32 31 34 30 30 38 30 33 30 30 30 30 30 30 30 30 2E 30 30 30 33 32 32 30 30 31 30 30 30 30 30 30 30 35 34 35 30 30 38 30 33 32 30 32 32 2E 30 30 30 30 30 30 30 30 35 34 36 00 00 0E 00 13 00 18 00 2D 00 65 00 60 00 34 00 2F 00 33 00 35 00 35 00 2D 00 30 00 30 00 2D 00 32 00 2E 00 2D 00 28 00 29 00 29 00 26 00 28 00 29 00 24 00 29 00 27 00 2B 00 2B 00 29 00 27 00 2A 00 2C 00 27 00 29 00 29 00 2D 00 28 00 2E 00 2D 00 2E 00 2F 00 2C 00 2D 00 2B 00 28 00 2D 00 2F 00 2D 00 2A 00 2C 00 2C 00 26 00 26 00 2B 00 29 00 25 00 26 00 27 00 24 00 24 00 23 00 22 00 24 00 21 00 25 00 23 00 28 00 26 00 25 00 25 00 28 00 2A 00 27 00 25 00 2D 00 2B 00 2C 00 28 00 2A 00 2D 00 29 00 27 00 2A 00 27 00 28 00 2B 00 28 00 2C 00 2A 00 29 00 28 00 2F 00 2C 00 2B 00 29 00 26 00 24 00 27 00 26 00 26 00 26 00 26 00 23 00 27 00 21 00 23 00 20 00 1E 00 27 00 28 00 24 00 29 00 27 00 27 00 2A 00 2E 00 2A 00 29 00 27 00 28 00 2A 00 2B 00 28 00 2C 00 2D 00 2A 00 2D 00 2D 00 2A 00 29 00 2B 00 29 00 2C 00 2D 00 2D 00 2F 00 2D 00 29 00 28 00 2B 00 29 00 25 00 27 00 23 00 27 00 25 00 24 00 22 00 22 00 23 00 24 00 22 00 22 00 28 00 24 00 27 00 29 00 28 00 2B 00 2C 00 2E 00 2A 00 2C 00 28 00 20 00 27 00 2A 00 30 00 26 00 24 00 2E 00 2B 00 2C 00 2D 00 2E 00 2D 00 2F 00 2C 00 2A 00 2C 00 2B 00 2A 00 25 00 2F 00 28 00 29 00 29 00 2B 00 28 00 28 00 2A 00 24 00 27 00 28 00 28 00 2B 00 27 00 2B 00 2D 00 2B 00 2A 00 28 00 30 00 2C 00 2A 00 2F 00 32 00 34 00 30 00 32 00 34 00 35 00 37 00 31 00 34 00 36 00 39 00 47 00 4E 00 48 00 37 00 2E 00 27 00 29 00 28 00 26 00 28 00 2F 00 2D 00 2E 00 2E 00 37 00 39 00 38 00 3A 00 3F 00 3B 00 3D 00 3E 00 3D 00 3C 00 36 00 39 00 37 00 32 00 34 00 33 00 31 00 31 00 2D 00 2F 00 31 00 37 00 34 00 35 00 3A 00 3C 00 3E 00 41 00 41 00 3D 00 3C 00 3B 00 38 00 36 00 32 00 30 00 30 00 32 00 2E 00 2B 00 2B 00 2B 00 30 00 37 00 34 00 35 00 37 00 35 00 3E 00 3C 00 3A 00 3A 00 39 00 36 00 34 00 36 00 33 00 34 00 32 00 2E 00 30 00 2A 00 2C 00 2B 00 2E 00 2E 00 31 00 37 00 38 00 38 00 39 00 3D 00 3A 00 3B 00 39 00 3A 00 37 00 35 00 32 00 30 00 2E 00 2C 00 2C 00 29 00 29 00 2B 00 2C 00 2C 00 32 00 31 00 35 00 3A 00 39 00 3B 00 37 00 3B 00 3B 00 33 00 30 00 33 00 2D 00 30 00 31 00 2D 00 2A 00 29 00 2A 00 28 00 2E 00 2E 00 32 00 32 00 2F 00 34 00 3B 00 3B 00 39 00 38 00 37 00 33 00 34 00 33 00 2F 00 2B 00 2B 00 2C 00 28 00 26 00 29 00 26 00 2A 00 2A 00 31 00 34 00 35 00 38 00 3A 00 36 00 37 00 36 00 33 00 36 00 32 00 2F 00 2C 00 29 00 28 00 28 00 22 00 1C 00 24 00 24 00 27 00 22 00 28 00 2B 00 30 00 32 00 33 00 34 00 31 00 30 00 34 00 2F 00 2C 00 2E 00 28 00 29 00 2B 00 2A 00 23 00 21 00 20 00 25 00 2A 00 28 00 2F 00 2D 00 31 00 32 00 33 00 39 00 31 00 38 00 35 00 30 00 30 00 2F 00 2D 00 2A 00 25 00 27 00 25 00 26 00 23 00 25 00 28 00 2C 00 2D 00 30 00 30 00 34 00 38 00 3A 00 36 00 35 00 34 00 33 00 31 00 2D 00 2E 00 28 00 27 00 22 00 2A 00 26 00 1F 00 15 00 11 00 14 00 1A 00 22 00 28 00 2D 00 33 00 2E 00 31 00 32 00 2E 00 27 00 22 00 1F 00 1B 00 1B 00 17 00 1C 00 1D 00 1F 00 1E 00 1D 00 21 00 20 00 24 00 27 00 22 00 28 00 2B 00 2C 00 2C 00 2C 00 2E 00 26 00 2A 00 25 00 22 00 23 00 1E 00 1F 00 19 00 1C 00 19 00 1C 00 26 00 22 00 20 00 27 00 28 00 2C 00 27 00 2B 00 2A 00 27 00 29 00 24 00 2B 00 23 00 23 00 24 00 21 00 21 00 1F 00 1E 00 1A 00 1D 00 21 00 20 00 22 00 27 00 29 00 2A 00 2A 00 2C 00 2D 00 29 00 27 00 27 00 25 00 26 00 21 00 22 00 1F 00 1D 00 1A 00 1E 00 1D 00 1F 00 1F 00 1D 00 24 00 23 00 2A 00 26 00 22 00 19";
            var form = new TraceCurveForm(new OpenProtocolTraceCurve(hexStr.HexStrToBytes()));
            form.Show();
        }
    }
}
