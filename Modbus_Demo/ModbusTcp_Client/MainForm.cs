using HslCommunication;
using HslCommunication.Core;
using HslCommunication.ModBus;
using System;
using System.Text;
using System.Windows.Forms;

namespace ModbusTcp_Client
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Modbus客户端
        /// </summary>
        ModbusTcpNet modbusClient;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            modbusClient?.ConnectClose();

            Environment.Exit(0);
        }

        /// <summary>
        /// 连接服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
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

            modbusClient = new ModbusTcpNet(ip, port)
            {
                //默认地址从0开始
                AddressStartWithZero = true,
                //默认低位在前
                DataFormat = DataFormat.CDAB,
                //默认字符串不颠倒
                IsStringReverse = false,
                //默认站号为1
                Station = Convert.ToByte(1),
                ConnectTimeOut = 3000,
                ReceiveTimeOut = 3000
            };
            //ModbusTcp长连接
            modbusClient.SetPersistentConnection();

            this.txtIP.Enabled = false;
            this.txtPort.Enabled = false;
            this.btnConnect.Enabled = false;
            this.btnDisconnect.Enabled = true;
            this.pnlRead.Enabled = true;
            this.pnlWrite.Enabled = true;
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            modbusClient?.ConnectClose();

            this.txtIP.Enabled = true;
            this.txtPort.Enabled = true;
            this.btnConnect.Enabled = true;
            this.btnDisconnect.Enabled = false;
            this.pnlRead.Enabled = false;
            this.pnlWrite.Enabled = false;
        }

        #region 读取点位

        /// <summary>
        /// 读取Int16
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadInt16_Click(object sender, EventArgs e)
        {
            if (modbusClient != null && ValidateBeforeRead(out string address))
            {
                OperateResult<short> operateResult = modbusClient.ReadInt16(address);
                if (operateResult.IsSuccess)
                {
                    this.txtReadContent.Text = operateResult.Content.ToString();
                }
                else
                {
                    MessageBox.Show($"读取失败：{operateResult.Message}");
                }
            }
        }

        /// <summary>
        /// 读取Float
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadFloat_Click(object sender, EventArgs e)
        {
            if (modbusClient != null && ValidateBeforeRead(out string address))
            {
                OperateResult<float> operateResult = modbusClient.ReadFloat(address);
                if (operateResult.IsSuccess)
                {
                    this.txtReadContent.Text = operateResult.Content.ToString();
                }
                else
                {
                    MessageBox.Show($"读取失败：{operateResult.Message}");
                }
            }
        }

        /// <summary>
        /// 读取Bool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadBool_Click(object sender, EventArgs e)
        {
            if (modbusClient != null && ValidateBeforeRead(out string address))
            {
                OperateResult<bool> operateResult = modbusClient.ReadBool(address);
                if (operateResult.IsSuccess)
                {
                    this.txtReadContent.Text = operateResult.Content.ToString();
                }
                else
                {
                    MessageBox.Show($"读取失败：{operateResult.Message}");
                }
            }
        }

        /// <summary>
        /// 读取String
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadString_Click(object sender, EventArgs e)
        {
            if (modbusClient != null && ValidateBeforeRead(out string address))
            {
                if (ushort.TryParse(this.txtReadLength.Text.Trim(), out ushort length))
                {
                    MessageBox.Show("请输入需要读取的字符串长度");
                    return;
                }

                OperateResult<string> operateResult = modbusClient.ReadString(address, length, Encoding.ASCII);
                if (operateResult.IsSuccess)
                {
                    this.txtReadContent.Text = operateResult.Content.ToString();
                }
                else
                {
                    MessageBox.Show($"读取失败：{operateResult.Message}");
                }
            }
        }

        /// <summary>
        /// 读取点位之前的通用校验
        /// </summary>
        /// <returns></returns>
        private bool ValidateBeforeRead(out string address)
        {
            this.txtReadContent.Clear();
            Application.DoEvents();

            address = this.txtReadAddress.Text.Trim();
            if (modbusClient == null)
            {
                MessageBox.Show("请先建立服务器连接");
                return false;
            }
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("请填写需要读取的地址");
                return false;
            }

            return true;
        }

        #endregion

        #region 写入点位

        /// <summary>
        /// 写入Int16
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWriteInt16_Click(object sender, EventArgs e)
        {
            if (modbusClient != null && ValidateBeforeWrite(out string address))
            {
                if (!short.TryParse(this.txtWriteValue.Text.Trim(), out short value))
                {
                    MessageBox.Show($"{this.txtWriteValue.Text.Trim()}不是一个有效的Int16值");
                }

                OperateResult operateResult = modbusClient.Write(address, value);
                if (operateResult.IsSuccess)
                {
                    MessageBox.Show("写入成功");
                }
                else
                {
                    MessageBox.Show($"写入失败：{operateResult.Message}");
                }
            }
        }

        /// <summary>
        /// 写入Float
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWriteFloat_Click(object sender, EventArgs e)
        {
            if (modbusClient != null && ValidateBeforeWrite(out string address))
            {
                if (!float.TryParse(this.txtWriteValue.Text.Trim(), out float value))
                {
                    MessageBox.Show($"{this.txtWriteValue.Text.Trim()}不是一个有效的Float值");
                }

                OperateResult operateResult = modbusClient.Write(address, value);
                if (operateResult.IsSuccess)
                {
                    MessageBox.Show("写入成功");
                }
                else
                {
                    MessageBox.Show($"写入失败：{operateResult.Message}");
                }
            }
        }

        /// <summary>
        /// 写入Bool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWriteBool_Click(object sender, EventArgs e)
        {
            if (modbusClient != null && ValidateBeforeWrite(out string address))
            {
                if (!bool.TryParse(this.txtWriteValue.Text.Trim(), out bool value))
                {
                    MessageBox.Show($"{this.txtWriteValue.Text.Trim()}不是一个有效的Bool值");
                }

                OperateResult operateResult = modbusClient.Write(address, value);
                if (operateResult.IsSuccess)
                {
                    MessageBox.Show("写入成功");
                }
                else
                {
                    MessageBox.Show($"写入失败：{operateResult.Message}");
                }
            }
        }

        /// <summary>
        /// 写入String
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWriteString_Click(object sender, EventArgs e)
        {
            if (modbusClient != null && ValidateBeforeWrite(out string address))
            {
                if (ushort.TryParse(this.txtWriteLength.Text.Trim(), out ushort length))
                {
                    MessageBox.Show("请输入需要写入的字符串长度");
                    return;
                }

                OperateResult operateResult = modbusClient.Write(address, this.txtWriteValue.Text.Trim(), length, Encoding.ASCII);
                if (operateResult.IsSuccess)
                {
                    MessageBox.Show("写入成功");
                }
                else
                {
                    MessageBox.Show($"写入失败：{operateResult.Message}");
                }
            }
        }

        /// <summary>
        /// 写入点位之前的通用校验
        /// </summary>
        /// <returns></returns>
        private bool ValidateBeforeWrite(out string address)
        {
            address = this.txtWriteAddress.Text.Trim();
            if (modbusClient == null)
            {
                MessageBox.Show("请先建立服务器连接");
                return false;
            }
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("请填写需要写入的地址");
                return false;
            }

            return true;
        }

        #endregion
    }
}
