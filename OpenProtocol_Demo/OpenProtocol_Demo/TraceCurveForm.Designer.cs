namespace OpenProtocol_Demo
{
    partial class TraceCurveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTraceCurve = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTighteningID = new System.Windows.Forms.Label();
            this.lblControllerTime = new System.Windows.Forms.Label();
            this.tcTraceCurve = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTraceSamples = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartTraceCurve)).BeginInit();
            this.tcTraceCurve.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartTraceCurve
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTraceCurve.ChartAreas.Add(chartArea1);
            this.chartTraceCurve.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartTraceCurve.Legends.Add(legend1);
            this.chartTraceCurve.Location = new System.Drawing.Point(3, 3);
            this.chartTraceCurve.Name = "chartTraceCurve";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTraceCurve.Series.Add(series1);
            this.chartTraceCurve.Size = new System.Drawing.Size(850, 450);
            this.chartTraceCurve.TabIndex = 0;
            this.chartTraceCurve.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "拧紧ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "控制器时间：";
            // 
            // lblTighteningID
            // 
            this.lblTighteningID.AutoSize = true;
            this.lblTighteningID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTighteningID.Location = new System.Drawing.Point(101, 20);
            this.lblTighteningID.Name = "lblTighteningID";
            this.lblTighteningID.Size = new System.Drawing.Size(35, 12);
            this.lblTighteningID.TabIndex = 1;
            this.lblTighteningID.Text = "00000";
            // 
            // lblControllerTime
            // 
            this.lblControllerTime.AutoSize = true;
            this.lblControllerTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblControllerTime.Location = new System.Drawing.Point(248, 20);
            this.lblControllerTime.Name = "lblControllerTime";
            this.lblControllerTime.Size = new System.Drawing.Size(119, 12);
            this.lblControllerTime.TabIndex = 1;
            this.lblControllerTime.Text = "2024-01-01 12:00:00";
            // 
            // tcTraceCurve
            // 
            this.tcTraceCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTraceCurve.Controls.Add(this.tabPage1);
            this.tcTraceCurve.Controls.Add(this.tabPage2);
            this.tcTraceCurve.Location = new System.Drawing.Point(0, 50);
            this.tcTraceCurve.Name = "tcTraceCurve";
            this.tcTraceCurve.SelectedIndex = 0;
            this.tcTraceCurve.Size = new System.Drawing.Size(864, 482);
            this.tcTraceCurve.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartTraceCurve);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(856, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "轨迹曲线";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTraceSamples);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(856, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据源";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTraceSamples
            // 
            this.txtTraceSamples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTraceSamples.BackColor = System.Drawing.Color.White;
            this.txtTraceSamples.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTraceSamples.Location = new System.Drawing.Point(8, 6);
            this.txtTraceSamples.Multiline = true;
            this.txtTraceSamples.Name = "txtTraceSamples";
            this.txtTraceSamples.ReadOnly = true;
            this.txtTraceSamples.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTraceSamples.Size = new System.Drawing.Size(839, 444);
            this.txtTraceSamples.TabIndex = 0;
            // 
            // TraceCurveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 531);
            this.Controls.Add(this.tcTraceCurve);
            this.Controls.Add(this.lblControllerTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTighteningID);
            this.Controls.Add(this.label1);
            this.Name = "TraceCurveForm";
            this.Text = "TraceCurveForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartTraceCurve)).EndInit();
            this.tcTraceCurve.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTraceCurve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTighteningID;
        private System.Windows.Forms.Label lblControllerTime;
        private System.Windows.Forms.TabControl tcTraceCurve;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtTraceSamples;
    }
}