namespace ModbusTcp_Client
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.pnlRead = new System.Windows.Forms.Panel();
            this.txtReadContent = new System.Windows.Forms.TextBox();
            this.txtReadLength = new System.Windows.Forms.TextBox();
            this.txtReadAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadString = new System.Windows.Forms.Button();
            this.btnReadFloat = new System.Windows.Forms.Button();
            this.btnReadBool = new System.Windows.Forms.Button();
            this.btnReadInt16 = new System.Windows.Forms.Button();
            this.cmsLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSaveLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlWrite = new System.Windows.Forms.Panel();
            this.txtWriteValue = new System.Windows.Forms.TextBox();
            this.txtWriteLength = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWriteAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnWriteString = new System.Windows.Forms.Button();
            this.btnWriteFloat = new System.Windows.Forms.Button();
            this.btnWriteBool = new System.Windows.Forms.Button();
            this.btnWriteInt16 = new System.Windows.Forms.Button();
            this.pnlRead.SuspendLayout();
            this.cmsLog.SuspendLayout();
            this.pnlWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(321, 11);
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
            this.txtPort.Text = "502";
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
            this.btnDisconnect.Location = new System.Drawing.Point(402, 11);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "断开连接";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // pnlRead
            // 
            this.pnlRead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRead.Controls.Add(this.txtReadContent);
            this.pnlRead.Controls.Add(this.txtReadLength);
            this.pnlRead.Controls.Add(this.txtReadAddress);
            this.pnlRead.Controls.Add(this.label9);
            this.pnlRead.Controls.Add(this.label8);
            this.pnlRead.Controls.Add(this.label7);
            this.pnlRead.Controls.Add(this.label3);
            this.pnlRead.Controls.Add(this.btnReadString);
            this.pnlRead.Controls.Add(this.btnReadFloat);
            this.pnlRead.Controls.Add(this.btnReadBool);
            this.pnlRead.Controls.Add(this.btnReadInt16);
            this.pnlRead.Enabled = false;
            this.pnlRead.Location = new System.Drawing.Point(14, 66);
            this.pnlRead.Name = "pnlRead";
            this.pnlRead.Size = new System.Drawing.Size(356, 367);
            this.pnlRead.TabIndex = 4;
            // 
            // txtReadContent
            // 
            this.txtReadContent.Location = new System.Drawing.Point(72, 144);
            this.txtReadContent.Multiline = true;
            this.txtReadContent.Name = "txtReadContent";
            this.txtReadContent.ReadOnly = true;
            this.txtReadContent.Size = new System.Drawing.Size(183, 115);
            this.txtReadContent.TabIndex = 6;
            // 
            // txtReadLength
            // 
            this.txtReadLength.Location = new System.Drawing.Point(72, 59);
            this.txtReadLength.Name = "txtReadLength";
            this.txtReadLength.Size = new System.Drawing.Size(75, 21);
            this.txtReadLength.TabIndex = 1;
            // 
            // txtReadAddress
            // 
            this.txtReadAddress.Location = new System.Drawing.Point(72, 32);
            this.txtReadAddress.Name = "txtReadAddress";
            this.txtReadAddress.Size = new System.Drawing.Size(183, 21);
            this.txtReadAddress.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "读取内容";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(153, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "读取字符串时需要指定长度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "长度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "地址";
            // 
            // btnReadString
            // 
            this.btnReadString.Location = new System.Drawing.Point(153, 115);
            this.btnReadString.Name = "btnReadString";
            this.btnReadString.Size = new System.Drawing.Size(75, 23);
            this.btnReadString.TabIndex = 5;
            this.btnReadString.Text = "读取String";
            this.btnReadString.UseVisualStyleBackColor = true;
            this.btnReadString.Click += new System.EventHandler(this.btnReadString_Click);
            // 
            // btnReadFloat
            // 
            this.btnReadFloat.Location = new System.Drawing.Point(153, 86);
            this.btnReadFloat.Name = "btnReadFloat";
            this.btnReadFloat.Size = new System.Drawing.Size(75, 23);
            this.btnReadFloat.TabIndex = 3;
            this.btnReadFloat.Text = "读取Float";
            this.btnReadFloat.UseVisualStyleBackColor = true;
            this.btnReadFloat.Click += new System.EventHandler(this.btnReadFloat_Click);
            // 
            // btnReadBool
            // 
            this.btnReadBool.Location = new System.Drawing.Point(72, 115);
            this.btnReadBool.Name = "btnReadBool";
            this.btnReadBool.Size = new System.Drawing.Size(75, 23);
            this.btnReadBool.TabIndex = 4;
            this.btnReadBool.Text = "读取Bool";
            this.btnReadBool.UseVisualStyleBackColor = true;
            this.btnReadBool.Click += new System.EventHandler(this.btnReadBool_Click);
            // 
            // btnReadInt16
            // 
            this.btnReadInt16.Location = new System.Drawing.Point(72, 86);
            this.btnReadInt16.Name = "btnReadInt16";
            this.btnReadInt16.Size = new System.Drawing.Size(75, 23);
            this.btnReadInt16.TabIndex = 2;
            this.btnReadInt16.Text = "读取Int16";
            this.btnReadInt16.UseVisualStyleBackColor = true;
            this.btnReadInt16.Click += new System.EventHandler(this.btnReadInt16_Click);
            // 
            // cmsLog
            // 
            this.cmsLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveLog,
            this.toolStripSeparator1,
            this.tsmiClearLog});
            this.cmsLog.Name = "cmsLog";
            this.cmsLog.Size = new System.Drawing.Size(69, 54);
            // 
            // tsmiSaveLog
            // 
            this.tsmiSaveLog.Name = "tsmiSaveLog";
            this.tsmiSaveLog.Size = new System.Drawing.Size(68, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(65, 6);
            // 
            // tsmiClearLog
            // 
            this.tsmiClearLog.Name = "tsmiClearLog";
            this.tsmiClearLog.Size = new System.Drawing.Size(68, 22);
            // 
            // pnlWrite
            // 
            this.pnlWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWrite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWrite.Controls.Add(this.txtWriteValue);
            this.pnlWrite.Controls.Add(this.txtWriteLength);
            this.pnlWrite.Controls.Add(this.label10);
            this.pnlWrite.Controls.Add(this.txtWriteAddress);
            this.pnlWrite.Controls.Add(this.label12);
            this.pnlWrite.Controls.Add(this.label13);
            this.pnlWrite.Controls.Add(this.label11);
            this.pnlWrite.Controls.Add(this.btnWriteString);
            this.pnlWrite.Controls.Add(this.btnWriteFloat);
            this.pnlWrite.Controls.Add(this.btnWriteBool);
            this.pnlWrite.Controls.Add(this.btnWriteInt16);
            this.pnlWrite.Enabled = false;
            this.pnlWrite.Location = new System.Drawing.Point(376, 66);
            this.pnlWrite.Name = "pnlWrite";
            this.pnlWrite.Size = new System.Drawing.Size(314, 367);
            this.pnlWrite.TabIndex = 5;
            // 
            // txtWriteValue
            // 
            this.txtWriteValue.Location = new System.Drawing.Point(72, 59);
            this.txtWriteValue.Name = "txtWriteValue";
            this.txtWriteValue.Size = new System.Drawing.Size(183, 21);
            this.txtWriteValue.TabIndex = 1;
            // 
            // txtWriteLength
            // 
            this.txtWriteLength.Location = new System.Drawing.Point(72, 86);
            this.txtWriteLength.Name = "txtWriteLength";
            this.txtWriteLength.Size = new System.Drawing.Size(75, 21);
            this.txtWriteLength.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "写入值";
            // 
            // txtWriteAddress
            // 
            this.txtWriteAddress.Location = new System.Drawing.Point(72, 32);
            this.txtWriteAddress.Name = "txtWriteAddress";
            this.txtWriteAddress.Size = new System.Drawing.Size(183, 21);
            this.txtWriteAddress.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label12.Location = new System.Drawing.Point(153, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "写入字符串时需要指定长度";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "地址";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "长度";
            // 
            // btnWriteString
            // 
            this.btnWriteString.Location = new System.Drawing.Point(153, 142);
            this.btnWriteString.Name = "btnWriteString";
            this.btnWriteString.Size = new System.Drawing.Size(75, 23);
            this.btnWriteString.TabIndex = 6;
            this.btnWriteString.Text = "读取String";
            this.btnWriteString.UseVisualStyleBackColor = true;
            this.btnWriteString.Click += new System.EventHandler(this.btnWriteString_Click);
            // 
            // btnWriteFloat
            // 
            this.btnWriteFloat.Location = new System.Drawing.Point(153, 113);
            this.btnWriteFloat.Name = "btnWriteFloat";
            this.btnWriteFloat.Size = new System.Drawing.Size(75, 23);
            this.btnWriteFloat.TabIndex = 4;
            this.btnWriteFloat.Text = "读取Float";
            this.btnWriteFloat.UseVisualStyleBackColor = true;
            this.btnWriteFloat.Click += new System.EventHandler(this.btnWriteFloat_Click);
            // 
            // btnWriteBool
            // 
            this.btnWriteBool.Location = new System.Drawing.Point(72, 142);
            this.btnWriteBool.Name = "btnWriteBool";
            this.btnWriteBool.Size = new System.Drawing.Size(75, 23);
            this.btnWriteBool.TabIndex = 5;
            this.btnWriteBool.Text = "读取Bool";
            this.btnWriteBool.UseVisualStyleBackColor = true;
            this.btnWriteBool.Click += new System.EventHandler(this.btnWriteBool_Click);
            // 
            // btnWriteInt16
            // 
            this.btnWriteInt16.Location = new System.Drawing.Point(72, 113);
            this.btnWriteInt16.Name = "btnWriteInt16";
            this.btnWriteInt16.Size = new System.Drawing.Size(75, 23);
            this.btnWriteInt16.TabIndex = 3;
            this.btnWriteInt16.Text = "读取Int16";
            this.btnWriteInt16.UseVisualStyleBackColor = true;
            this.btnWriteInt16.Click += new System.EventHandler(this.btnWriteInt16_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 445);
            this.Controls.Add(this.pnlWrite);
            this.Controls.Add(this.pnlRead);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModbusTcp_Client_Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.pnlRead.ResumeLayout(false);
            this.pnlRead.PerformLayout();
            this.cmsLog.ResumeLayout(false);
            this.pnlWrite.ResumeLayout(false);
            this.pnlWrite.PerformLayout();
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
        private System.Windows.Forms.Panel pnlRead;
        private System.Windows.Forms.ContextMenuStrip cmsLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveLog;
        private System.Windows.Forms.TextBox txtReadLength;
        private System.Windows.Forms.TextBox txtReadAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReadInt16;
        private System.Windows.Forms.Button btnReadFloat;
        private System.Windows.Forms.Button btnReadBool;
        private System.Windows.Forms.Button btnReadString;
        private System.Windows.Forms.TextBox txtReadContent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlWrite;
        private System.Windows.Forms.TextBox txtWriteAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnWriteString;
        private System.Windows.Forms.Button btnWriteFloat;
        private System.Windows.Forms.Button btnWriteBool;
        private System.Windows.Forms.Button btnWriteInt16;
        private System.Windows.Forms.TextBox txtWriteValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWriteLength;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}