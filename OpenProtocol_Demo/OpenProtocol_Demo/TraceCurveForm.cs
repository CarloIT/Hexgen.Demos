using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WIT.Global;

namespace OpenProtocol_Demo
{
    public partial class TraceCurveForm : Form
    {
        /// <summary>
        /// 构造函数，绘制单一轨迹曲线
        /// </summary>
        /// <param name="traceCurve">轨迹曲线</param>
        public TraceCurveForm(OpenProtocolTraceCurve traceCurve)
        {
            InitializeComponent();

            this.Text = $"轨迹曲线 [{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}]";

            this.lblTighteningID.Text = traceCurve.TighteningID.ToString();
            this.lblControllerTime.Text = traceCurve.Timestamp.ToString("yyyy-MM-dd HH:mm:ss");

            this.tabPage1.Text = $"轨迹曲线（时间-{traceCurve.TraceTypeDesc}）";
            //绘制Chart
            DrawChart(new List<OpenProtocolTraceCurve> { traceCurve });

            //打印原始数据
            this.tabPage2.Text = $"原始数据源（{traceCurve.NumberOfTraceSamples}个采样点）";
            this.txtTraceSamples.Text = string.Join(",", traceCurve.TraceSamples);
        }

        /// <summary>
        /// 构造函数，绘制完整拧紧数据包
        /// </summary>
        /// <param name="dataPackage">拧紧数据包</param>
        public TraceCurveForm(OpenProtocolTighteningDataPackage dataPackage)
        {
            InitializeComponent();

            if (dataPackage.TraceCurves.Count == 0)
            {
                throw new ArgumentOutOfRangeException("拧紧数据包中的轨迹曲线数量为0，超出了预期。");
            }
            else if (dataPackage.TraceCurves.Count > 1)
            {
                if (dataPackage.TraceCurves.Select(t => t.NumberOfTraceSamples).Distinct().Count() > 1)
                {
                    throw new ArgumentOutOfRangeException($"拧紧数据包中包含了{dataPackage.TraceCurves.Count}种轨迹类型，但是它们具备不同的样本数量，这超出了预期。");
                }
            }

            this.Text = $"拧紧数据包 [{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}]";

            this.lblTighteningID.Text = dataPackage.TighteningResult.TighteningID.ToString();
            this.lblControllerTime.Text = dataPackage.TighteningResult.Timestamp.ToString("yyyy-MM-dd HH:mm:ss");

            this.tabPage1.Text = $"轨迹曲线（时间-{string.Join("/", dataPackage.TraceCurves.Select(t => t.TraceTypeDesc))}）";
            //绘制Chart
            DrawChart(dataPackage.TraceCurves);

            //打印原始数据
            this.tabPage2.Text = $"原始数据源（{dataPackage.TraceCurves[0].NumberOfTraceSamples}个采样点）";
            this.txtTraceSamples.Text = JsonConvert.SerializeObject(dataPackage);
        }

        /// <summary>
        /// 绘制Chart
        /// </summary>
        /// <param name="traceCurves">多种轨迹曲线</param>
        void DrawChart(List<OpenProtocolTraceCurve> traceCurves)
        {
            foreach (var item in traceCurves)
            {
                Series series = new Series
                {
                    //Series样式
                    ChartType = SeriesChartType.Spline,
                    BorderWidth = 2,
                    Color = Color.Red,
                    //MarkerStyle = MarkerStyle.Circle,
                    //MarkerSize = 4,
                    LegendText = $"{item.TraceTypeDesc}曲线",
                    IsVisibleInLegend = false,
                    ToolTip = $"时间：#VALX {item.TraceSamplesTimeUnitDesc}\r\n{item.TraceTypeDesc}：#VAL {item.UnitDesc}"
                };
                //添加曲线数据
                for (int i = 1; i <= item.NumberOfTraceSamples; i++)
                {
                    series.Points.AddXY(item.TraceSamplesTime[i - 1], item.TraceSamples[i - 1]);
                }
                this.chartTraceCurve.Series.Add(series);
            }

            //设置显示范围
            ChartArea chartArea = this.chartTraceCurve.ChartAreas[0];
            chartArea.AxisX.Minimum = (double)traceCurves[0].TraceSamplesTime[0];
            chartArea.AxisX.Maximum = (double)traceCurves[0].TraceSamplesTime[traceCurves[0].NumberOfTraceSamples - 1];
            chartArea.AxisX.LabelStyle.Format = "{0}" + traceCurves[0].TraceSamplesTimeUnitDesc;
            var minValue = Convert.ToDouble(traceCurves.Select(t => t.TraceSamples.Min()).Min());
            chartArea.AxisY.Minimum = minValue >= 0 ? 0 : minValue;
            var maxValue = Convert.ToDouble(traceCurves.Select(t => t.TraceSamples.Max()).Max() * 1.2m);
            chartArea.AxisY.Maximum = Convert.ToDouble(maxValue.ToString("0.####"));
            if (traceCurves.Count == 1)
            {
                chartArea.AxisY.LabelStyle.Format = "{0:0.000}" + traceCurves[0].UnitDesc;
            }
            else
            {
                chartArea.AxisY.LabelStyle.Format = "{0:0.000}";
            }
        }
    }
}
