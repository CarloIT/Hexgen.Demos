namespace OpenProtocol_Demo
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnSubscribeLastTighteningResult = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnSelectPset = new System.Windows.Forms.Button();
            this.btnUnsubscribeLastTighteningResult = new System.Windows.Forms.Button();
            this.txtPSetID = new System.Windows.Forms.TextBox();
            this.pnlFunctions = new System.Windows.Forms.Panel();
            this.btnSelectJob = new System.Windows.Forms.Button();
            this.btnCommunicationStop = new System.Windows.Forms.Button();
            this.btnKeepAlive = new System.Windows.Forms.Button();
            this.btnCommunicationStart = new System.Windows.Forms.Button();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSubscribedForceTrace = new System.Windows.Forms.CheckBox();
            this.cbForceTrace = new System.Windows.Forms.CheckBox();
            this.btnSubscribeLatestTraceCurve = new System.Windows.Forms.Button();
            this.cbSubscribedStrokeTrace = new System.Windows.Forms.CheckBox();
            this.cbStrokeTrace = new System.Windows.Forms.CheckBox();
            this.btnUnsubscribeTraceCurve = new System.Windows.Forms.Button();
            this.cbSubscribedGradientTrace = new System.Windows.Forms.CheckBox();
            this.cbGradientTrace = new System.Windows.Forms.CheckBox();
            this.cbSubscribedTorqueTrace = new System.Windows.Forms.CheckBox();
            this.cbTorqueTrace = new System.Windows.Forms.CheckBox();
            this.cbSubscribedCurrentTrace = new System.Windows.Forms.CheckBox();
            this.cbCurrentTrace = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSubscribedAngleTrace = new System.Windows.Forms.CheckBox();
            this.cbAngleTrace = new System.Windows.Forms.CheckBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.cmsLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSaveLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.cbShowHeartbeat = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbConnectionState = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbHeartbeat = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbCommunicationState = new System.Windows.Forms.PictureBox();
            this.btnShowTraceCurve = new System.Windows.Forms.Button();
            this.pnlFunctions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmsLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeartbeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommunicationState)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(321, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(51, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 21);
            this.txtIP.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(205, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "4545";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(402, 10);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "断开连接";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnSubscribeLastTighteningResult
            // 
            this.btnSubscribeLastTighteningResult.Location = new System.Drawing.Point(37, 56);
            this.btnSubscribeLastTighteningResult.Name = "btnSubscribeLastTighteningResult";
            this.btnSubscribeLastTighteningResult.Size = new System.Drawing.Size(99, 23);
            this.btnSubscribeLastTighteningResult.TabIndex = 2;
            this.btnSubscribeLastTighteningResult.Text = "订阅拧紧结果";
            this.btnSubscribeLastTighteningResult.UseVisualStyleBackColor = true;
            this.btnSubscribeLastTighteningResult.Click += new System.EventHandler(this.btnSubscribeLastTighteningResult_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(37, 27);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(99, 23);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "使能";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(142, 27);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(110, 23);
            this.btnDisable.TabIndex = 1;
            this.btnDisable.Text = "去使能";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnSelectPset
            // 
            this.btnSelectPset.Location = new System.Drawing.Point(37, 85);
            this.btnSelectPset.Name = "btnSelectPset";
            this.btnSelectPset.Size = new System.Drawing.Size(99, 23);
            this.btnSelectPset.TabIndex = 4;
            this.btnSelectPset.Text = "切换拧紧程序";
            this.btnSelectPset.UseVisualStyleBackColor = true;
            this.btnSelectPset.Click += new System.EventHandler(this.btnSelectPset_Click);
            // 
            // btnUnsubscribeLastTighteningResult
            // 
            this.btnUnsubscribeLastTighteningResult.Location = new System.Drawing.Point(142, 56);
            this.btnUnsubscribeLastTighteningResult.Name = "btnUnsubscribeLastTighteningResult";
            this.btnUnsubscribeLastTighteningResult.Size = new System.Drawing.Size(110, 23);
            this.btnUnsubscribeLastTighteningResult.TabIndex = 3;
            this.btnUnsubscribeLastTighteningResult.Text = "取消订阅拧紧结果";
            this.btnUnsubscribeLastTighteningResult.UseVisualStyleBackColor = true;
            this.btnUnsubscribeLastTighteningResult.Click += new System.EventHandler(this.btnUnsubscribeLastTighteningResult_Click);
            // 
            // txtPSetID
            // 
            this.txtPSetID.Location = new System.Drawing.Point(142, 86);
            this.txtPSetID.Name = "txtPSetID";
            this.txtPSetID.Size = new System.Drawing.Size(110, 21);
            this.txtPSetID.TabIndex = 5;
            this.txtPSetID.Text = "1";
            // 
            // pnlFunctions
            // 
            this.pnlFunctions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFunctions.Controls.Add(this.btnSelectJob);
            this.pnlFunctions.Controls.Add(this.btnCommunicationStop);
            this.pnlFunctions.Controls.Add(this.btnKeepAlive);
            this.pnlFunctions.Controls.Add(this.btnCommunicationStart);
            this.pnlFunctions.Controls.Add(this.btnSubscribeLastTighteningResult);
            this.pnlFunctions.Controls.Add(this.btnUnsubscribeLastTighteningResult);
            this.pnlFunctions.Controls.Add(this.btnEnable);
            this.pnlFunctions.Controls.Add(this.txtJobID);
            this.pnlFunctions.Controls.Add(this.txtPSetID);
            this.pnlFunctions.Controls.Add(this.btnDisable);
            this.pnlFunctions.Controls.Add(this.btnSelectPset);
            this.pnlFunctions.Controls.Add(this.panel1);
            this.pnlFunctions.Enabled = false;
            this.pnlFunctions.Location = new System.Drawing.Point(14, 66);
            this.pnlFunctions.Name = "pnlFunctions";
            this.pnlFunctions.Size = new System.Drawing.Size(662, 252);
            this.pnlFunctions.TabIndex = 4;
            // 
            // btnSelectJob
            // 
            this.btnSelectJob.Location = new System.Drawing.Point(37, 114);
            this.btnSelectJob.Name = "btnSelectJob";
            this.btnSelectJob.Size = new System.Drawing.Size(99, 23);
            this.btnSelectJob.TabIndex = 6;
            this.btnSelectJob.Text = "切换拧紧任务";
            this.btnSelectJob.UseVisualStyleBackColor = true;
            this.btnSelectJob.Click += new System.EventHandler(this.btnSelectJob_Click);
            // 
            // btnCommunicationStop
            // 
            this.btnCommunicationStop.Enabled = false;
            this.btnCommunicationStop.Location = new System.Drawing.Point(142, 143);
            this.btnCommunicationStop.Name = "btnCommunicationStop";
            this.btnCommunicationStop.Size = new System.Drawing.Size(110, 23);
            this.btnCommunicationStop.TabIndex = 9;
            this.btnCommunicationStop.Text = "断开服务器通信";
            this.btnCommunicationStop.UseVisualStyleBackColor = true;
            this.btnCommunicationStop.Click += new System.EventHandler(this.btnCommunicationStop_Click);
            // 
            // btnKeepAlive
            // 
            this.btnKeepAlive.Location = new System.Drawing.Point(37, 182);
            this.btnKeepAlive.Name = "btnKeepAlive";
            this.btnKeepAlive.Size = new System.Drawing.Size(116, 23);
            this.btnKeepAlive.TabIndex = 11;
            this.btnKeepAlive.Text = "手动发送一次心跳";
            this.btnKeepAlive.UseVisualStyleBackColor = true;
            this.btnKeepAlive.Click += new System.EventHandler(this.btnKeepAlive_Click);
            // 
            // btnCommunicationStart
            // 
            this.btnCommunicationStart.Enabled = false;
            this.btnCommunicationStart.Location = new System.Drawing.Point(37, 143);
            this.btnCommunicationStart.Name = "btnCommunicationStart";
            this.btnCommunicationStart.Size = new System.Drawing.Size(99, 23);
            this.btnCommunicationStart.TabIndex = 8;
            this.btnCommunicationStart.Text = "建立服务器通信";
            this.btnCommunicationStart.UseVisualStyleBackColor = true;
            this.btnCommunicationStart.Click += new System.EventHandler(this.btnCommunicationStart_Click);
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(142, 115);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(110, 21);
            this.txtJobID.TabIndex = 7;
            this.txtJobID.Text = "1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbSubscribedForceTrace);
            this.panel1.Controls.Add(this.cbForceTrace);
            this.panel1.Controls.Add(this.btnSubscribeLatestTraceCurve);
            this.panel1.Controls.Add(this.cbSubscribedStrokeTrace);
            this.panel1.Controls.Add(this.cbStrokeTrace);
            this.panel1.Controls.Add(this.btnUnsubscribeTraceCurve);
            this.panel1.Controls.Add(this.cbSubscribedGradientTrace);
            this.panel1.Controls.Add(this.cbGradientTrace);
            this.panel1.Controls.Add(this.cbSubscribedTorqueTrace);
            this.panel1.Controls.Add(this.cbTorqueTrace);
            this.panel1.Controls.Add(this.cbSubscribedCurrentTrace);
            this.panel1.Controls.Add(this.cbCurrentTrace);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbSubscribedAngleTrace);
            this.panel1.Controls.Add(this.cbAngleTrace);
            this.panel1.Location = new System.Drawing.Point(283, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 165);
            this.panel1.TabIndex = 10;
            // 
            // cbSubscribedForceTrace
            // 
            this.cbSubscribedForceTrace.AutoSize = true;
            this.cbSubscribedForceTrace.Enabled = false;
            this.cbSubscribedForceTrace.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSubscribedForceTrace.Location = new System.Drawing.Point(284, 28);
            this.cbSubscribedForceTrace.Name = "cbSubscribedForceTrace";
            this.cbSubscribedForceTrace.Size = new System.Drawing.Size(37, 16);
            this.cbSubscribedForceTrace.TabIndex = 5;
            this.cbSubscribedForceTrace.Text = "力";
            this.cbSubscribedForceTrace.UseVisualStyleBackColor = true;
            // 
            // cbForceTrace
            // 
            this.cbForceTrace.AutoSize = true;
            this.cbForceTrace.Location = new System.Drawing.Point(284, 85);
            this.cbForceTrace.Name = "cbForceTrace";
            this.cbForceTrace.Size = new System.Drawing.Size(36, 16);
            this.cbForceTrace.TabIndex = 13;
            this.cbForceTrace.Text = "力";
            this.cbForceTrace.UseVisualStyleBackColor = true;
            // 
            // btnSubscribeLatestTraceCurve
            // 
            this.btnSubscribeLatestTraceCurve.Location = new System.Drawing.Point(14, 56);
            this.btnSubscribeLatestTraceCurve.Name = "btnSubscribeLatestTraceCurve";
            this.btnSubscribeLatestTraceCurve.Size = new System.Drawing.Size(110, 23);
            this.btnSubscribeLatestTraceCurve.TabIndex = 6;
            this.btnSubscribeLatestTraceCurve.Text = "订阅最新轨迹曲线";
            this.btnSubscribeLatestTraceCurve.UseVisualStyleBackColor = true;
            this.btnSubscribeLatestTraceCurve.Click += new System.EventHandler(this.btnSubscribeLatestTraceCurve_Click);
            // 
            // cbSubscribedStrokeTrace
            // 
            this.cbSubscribedStrokeTrace.AutoSize = true;
            this.cbSubscribedStrokeTrace.Enabled = false;
            this.cbSubscribedStrokeTrace.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSubscribedStrokeTrace.Location = new System.Drawing.Point(230, 28);
            this.cbSubscribedStrokeTrace.Name = "cbSubscribedStrokeTrace";
            this.cbSubscribedStrokeTrace.Size = new System.Drawing.Size(50, 16);
            this.cbSubscribedStrokeTrace.TabIndex = 4;
            this.cbSubscribedStrokeTrace.Text = "冲程";
            this.cbSubscribedStrokeTrace.UseVisualStyleBackColor = true;
            // 
            // cbStrokeTrace
            // 
            this.cbStrokeTrace.AutoSize = true;
            this.cbStrokeTrace.Location = new System.Drawing.Point(230, 85);
            this.cbStrokeTrace.Name = "cbStrokeTrace";
            this.cbStrokeTrace.Size = new System.Drawing.Size(48, 16);
            this.cbStrokeTrace.TabIndex = 12;
            this.cbStrokeTrace.Text = "冲程";
            this.cbStrokeTrace.UseVisualStyleBackColor = true;
            // 
            // btnUnsubscribeTraceCurve
            // 
            this.btnUnsubscribeTraceCurve.Location = new System.Drawing.Point(130, 56);
            this.btnUnsubscribeTraceCurve.Name = "btnUnsubscribeTraceCurve";
            this.btnUnsubscribeTraceCurve.Size = new System.Drawing.Size(110, 23);
            this.btnUnsubscribeTraceCurve.TabIndex = 7;
            this.btnUnsubscribeTraceCurve.Text = "取消订阅轨迹曲线";
            this.btnUnsubscribeTraceCurve.UseVisualStyleBackColor = true;
            this.btnUnsubscribeTraceCurve.Click += new System.EventHandler(this.btnUnsubscribeTraceCurve_Click);
            // 
            // cbSubscribedGradientTrace
            // 
            this.cbSubscribedGradientTrace.AutoSize = true;
            this.cbSubscribedGradientTrace.Enabled = false;
            this.cbSubscribedGradientTrace.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSubscribedGradientTrace.Location = new System.Drawing.Point(176, 28);
            this.cbSubscribedGradientTrace.Name = "cbSubscribedGradientTrace";
            this.cbSubscribedGradientTrace.Size = new System.Drawing.Size(50, 16);
            this.cbSubscribedGradientTrace.TabIndex = 3;
            this.cbSubscribedGradientTrace.Text = "坡度";
            this.cbSubscribedGradientTrace.UseVisualStyleBackColor = true;
            // 
            // cbGradientTrace
            // 
            this.cbGradientTrace.AutoSize = true;
            this.cbGradientTrace.Location = new System.Drawing.Point(176, 85);
            this.cbGradientTrace.Name = "cbGradientTrace";
            this.cbGradientTrace.Size = new System.Drawing.Size(48, 16);
            this.cbGradientTrace.TabIndex = 11;
            this.cbGradientTrace.Text = "坡度";
            this.cbGradientTrace.UseVisualStyleBackColor = true;
            // 
            // cbSubscribedTorqueTrace
            // 
            this.cbSubscribedTorqueTrace.AutoSize = true;
            this.cbSubscribedTorqueTrace.Enabled = false;
            this.cbSubscribedTorqueTrace.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSubscribedTorqueTrace.Location = new System.Drawing.Point(68, 28);
            this.cbSubscribedTorqueTrace.Name = "cbSubscribedTorqueTrace";
            this.cbSubscribedTorqueTrace.Size = new System.Drawing.Size(50, 16);
            this.cbSubscribedTorqueTrace.TabIndex = 1;
            this.cbSubscribedTorqueTrace.Text = "扭矩";
            this.cbSubscribedTorqueTrace.UseVisualStyleBackColor = true;
            // 
            // cbTorqueTrace
            // 
            this.cbTorqueTrace.AutoSize = true;
            this.cbTorqueTrace.Location = new System.Drawing.Point(68, 85);
            this.cbTorqueTrace.Name = "cbTorqueTrace";
            this.cbTorqueTrace.Size = new System.Drawing.Size(48, 16);
            this.cbTorqueTrace.TabIndex = 9;
            this.cbTorqueTrace.Text = "扭矩";
            this.cbTorqueTrace.UseVisualStyleBackColor = true;
            // 
            // cbSubscribedCurrentTrace
            // 
            this.cbSubscribedCurrentTrace.AutoSize = true;
            this.cbSubscribedCurrentTrace.Enabled = false;
            this.cbSubscribedCurrentTrace.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSubscribedCurrentTrace.Location = new System.Drawing.Point(122, 28);
            this.cbSubscribedCurrentTrace.Name = "cbSubscribedCurrentTrace";
            this.cbSubscribedCurrentTrace.Size = new System.Drawing.Size(50, 16);
            this.cbSubscribedCurrentTrace.TabIndex = 2;
            this.cbSubscribedCurrentTrace.Text = "电流";
            this.cbSubscribedCurrentTrace.UseVisualStyleBackColor = true;
            // 
            // cbCurrentTrace
            // 
            this.cbCurrentTrace.AutoSize = true;
            this.cbCurrentTrace.Location = new System.Drawing.Point(122, 85);
            this.cbCurrentTrace.Name = "cbCurrentTrace";
            this.cbCurrentTrace.Size = new System.Drawing.Size(48, 16);
            this.cbCurrentTrace.TabIndex = 10;
            this.cbCurrentTrace.Text = "电流";
            this.cbCurrentTrace.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "当前已订阅的轨迹类型：";
            // 
            // cbSubscribedAngleTrace
            // 
            this.cbSubscribedAngleTrace.AutoSize = true;
            this.cbSubscribedAngleTrace.Enabled = false;
            this.cbSubscribedAngleTrace.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSubscribedAngleTrace.Location = new System.Drawing.Point(14, 28);
            this.cbSubscribedAngleTrace.Name = "cbSubscribedAngleTrace";
            this.cbSubscribedAngleTrace.Size = new System.Drawing.Size(50, 16);
            this.cbSubscribedAngleTrace.TabIndex = 0;
            this.cbSubscribedAngleTrace.Text = "角度";
            this.cbSubscribedAngleTrace.UseVisualStyleBackColor = true;
            // 
            // cbAngleTrace
            // 
            this.cbAngleTrace.AutoSize = true;
            this.cbAngleTrace.Location = new System.Drawing.Point(14, 85);
            this.cbAngleTrace.Name = "cbAngleTrace";
            this.cbAngleTrace.Size = new System.Drawing.Size(48, 16);
            this.cbAngleTrace.TabIndex = 8;
            this.cbAngleTrace.Text = "角度";
            this.cbAngleTrace.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.ContextMenuStrip = this.cmsLog;
            this.txtLog.Location = new System.Drawing.Point(13, 352);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(909, 376);
            this.txtLog.TabIndex = 6;
            // 
            // cmsLog
            // 
            this.cmsLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveLog,
            this.toolStripSeparator1,
            this.tsmiClearLog});
            this.cmsLog.Name = "cmsLog";
            this.cmsLog.Size = new System.Drawing.Size(141, 54);
            // 
            // tsmiSaveLog
            // 
            this.tsmiSaveLog.Name = "tsmiSaveLog";
            this.tsmiSaveLog.Size = new System.Drawing.Size(140, 22);
            this.tsmiSaveLog.Text = "保存日志(&S)";
            this.tsmiSaveLog.Click += new System.EventHandler(this.tsmiSaveLog_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmiClearLog
            // 
            this.tsmiClearLog.Name = "tsmiClearLog";
            this.tsmiClearLog.Size = new System.Drawing.Size(140, 22);
            this.tsmiClearLog.Text = "清空日志(&C)";
            this.tsmiClearLog.Click += new System.EventHandler(this.tsmiClearLog_Click);
            // 
            // cbShowHeartbeat
            // 
            this.cbShowHeartbeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShowHeartbeat.AutoSize = true;
            this.cbShowHeartbeat.Checked = true;
            this.cbShowHeartbeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowHeartbeat.Location = new System.Drawing.Point(849, 329);
            this.cbShowHeartbeat.Name = "cbShowHeartbeat";
            this.cbShowHeartbeat.Size = new System.Drawing.Size(72, 16);
            this.cbShowHeartbeat.TabIndex = 5;
            this.cbShowHeartbeat.Text = "显示心跳";
            this.cbShowHeartbeat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "收发数据日志：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "连接状态";
            // 
            // pbConnectionState
            // 
            this.pbConnectionState.Image = global::OpenProtocol_Demo.Properties.Resources.circle_grey;
            this.pbConnectionState.Location = new System.Drawing.Point(87, 44);
            this.pbConnectionState.Name = "pbConnectionState";
            this.pbConnectionState.Size = new System.Drawing.Size(16, 16);
            this.pbConnectionState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConnectionState.TabIndex = 12;
            this.pbConnectionState.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "心跳";
            // 
            // pbHeartbeat
            // 
            this.pbHeartbeat.Image = ((System.Drawing.Image)(resources.GetObject("pbHeartbeat.Image")));
            this.pbHeartbeat.Location = new System.Drawing.Point(331, 44);
            this.pbHeartbeat.Name = "pbHeartbeat";
            this.pbHeartbeat.Size = new System.Drawing.Size(16, 16);
            this.pbHeartbeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeartbeat.TabIndex = 12;
            this.pbHeartbeat.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "通信状态";
            // 
            // pbCommunicationState
            // 
            this.pbCommunicationState.Image = ((System.Drawing.Image)(resources.GetObject("pbCommunicationState.Image")));
            this.pbCommunicationState.Location = new System.Drawing.Point(218, 44);
            this.pbCommunicationState.Name = "pbCommunicationState";
            this.pbCommunicationState.Size = new System.Drawing.Size(16, 16);
            this.pbCommunicationState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCommunicationState.TabIndex = 12;
            this.pbCommunicationState.TabStop = false;
            // 
            // btnShowTraceCurve
            // 
            this.btnShowTraceCurve.Location = new System.Drawing.Point(682, 66);
            this.btnShowTraceCurve.Name = "btnShowTraceCurve";
            this.btnShowTraceCurve.Size = new System.Drawing.Size(120, 23);
            this.btnShowTraceCurve.TabIndex = 13;
            this.btnShowTraceCurve.Text = "演示轨迹曲线";
            this.btnShowTraceCurve.UseVisualStyleBackColor = true;
            this.btnShowTraceCurve.Click += new System.EventHandler(this.btnShowTraceCurve_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 741);
            this.Controls.Add(this.btnShowTraceCurve);
            this.Controls.Add(this.pbHeartbeat);
            this.Controls.Add(this.pbCommunicationState);
            this.Controls.Add(this.pbConnectionState);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbShowHeartbeat);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.pnlFunctions);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenProtocol_Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlFunctions.ResumeLayout(false);
            this.pnlFunctions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeartbeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommunicationState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnSubscribeLastTighteningResult;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnSelectPset;
        private System.Windows.Forms.Button btnUnsubscribeLastTighteningResult;
        private System.Windows.Forms.TextBox txtPSetID;
        private System.Windows.Forms.Panel pnlFunctions;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.CheckBox cbShowHeartbeat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbConnectionState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbHeartbeat;
        private System.Windows.Forms.ContextMenuStrip cmsLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearLog;
        private System.Windows.Forms.Button btnKeepAlive;
        private System.Windows.Forms.Button btnCommunicationStop;
        private System.Windows.Forms.Button btnCommunicationStart;
        private System.Windows.Forms.Button btnSelectJob;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveLog;
        private System.Windows.Forms.Button btnSubscribeLatestTraceCurve;
        private System.Windows.Forms.Button btnUnsubscribeTraceCurve;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbCommunicationState;
        private System.Windows.Forms.CheckBox cbTorqueTrace;
        private System.Windows.Forms.CheckBox cbForceTrace;
        private System.Windows.Forms.CheckBox cbStrokeTrace;
        private System.Windows.Forms.CheckBox cbGradientTrace;
        private System.Windows.Forms.CheckBox cbCurrentTrace;
        private System.Windows.Forms.CheckBox cbAngleTrace;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowTraceCurve;
        private System.Windows.Forms.CheckBox cbSubscribedForceTrace;
        private System.Windows.Forms.CheckBox cbSubscribedStrokeTrace;
        private System.Windows.Forms.CheckBox cbSubscribedGradientTrace;
        private System.Windows.Forms.CheckBox cbSubscribedTorqueTrace;
        private System.Windows.Forms.CheckBox cbSubscribedCurrentTrace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbSubscribedAngleTrace;
    }
}