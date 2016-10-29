using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using Be.Windows.Forms;

namespace SerialHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Form1_ControlAdded);
            InitializeComponent();
        }
        //*********************
        //维护线程安全----Start
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox_RX.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox_RX.Text = text;
            }
        }
        delegate void SetHexPerLineback(int len);
        private void SetHexPerLine(int len)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.hexBoxRX.InvokeRequired)
            {
                SetHexPerLineback d = new SetHexPerLineback(SetHexPerLine);
                this.Invoke(d, new object[] { len });
            }
            else
            {
                hexBoxRX.BytesPerLine = len;
            }
        }
        //维护线程安全----End
        //*********************
        //*******************************************************************

        //*********************
        //串口相关变量初始化----Start
        string currentCOM = "";
        int[] baudRateArr = {1200,2400,4800,9600,14400,
        19200,38400,56000,57600,115200,128000,256000 };
        int[] dataLenthArr = { 5, 6, 7, 8 };
        StopBits[] stopBitsArr = { StopBits.One, StopBits.OnePointFive, StopBits.Two, StopBits.None };
        Parity[] parityArr = { Parity.None, Parity.Space, Parity.Mark, Parity.Odd, Parity.Even };
        //串口相关变量初始化----End
        //*********************
        /// <summary>
        /// 枚举win32 api
        /// </summary>
        public enum HardwareEnum
        {
            // 硬件
            Win32_Processor, // CPU 处理器
            Win32_PhysicalMemory, // 物理内存条
            Win32_Keyboard, // 键盘
            Win32_PointingDevice, // 点输入设备，包括鼠标。
            Win32_FloppyDrive, // 软盘驱动器
            Win32_DiskDrive, // 硬盘驱动器
            Win32_CDROMDrive, // 光盘驱动器
            Win32_BaseBoard, // 主板
            Win32_BIOS, // BIOS 芯片
            Win32_ParallelPort, // 并口
            Win32_SerialPort, // 串口
            Win32_SerialPortConfiguration, // 串口配置
            Win32_SoundDevice, // 多媒体设置，一般指声卡。
            Win32_SystemSlot, // 主板插槽 (ISA & PCI & AGP)
            Win32_USBController, // USB 控制器
            Win32_NetworkAdapter, // 网络适配器
            Win32_NetworkAdapterConfiguration, // 网络适配器设置
            Win32_Printer, // 打印机
            Win32_PrinterConfiguration, // 打印机设置
            Win32_PrintJob, // 打印机任务
            Win32_TCPIPPrinterPort, // 打印机端口
            Win32_POTSModem, // MODEM
            Win32_POTSModemToSerialPort, // MODEM 端口
            Win32_DesktopMonitor, // 显示器
            Win32_DisplayConfiguration, // 显卡
            Win32_DisplayControllerConfiguration, // 显卡设置
            Win32_VideoController, // 显卡细节。
            Win32_VideoSettings, // 显卡支持的显示模式。

            // 操作系统
            Win32_TimeZone, // 时区
            Win32_SystemDriver, // 驱动程序
            Win32_DiskPartition, // 磁盘分区
            Win32_LogicalDisk, // 逻辑磁盘
            Win32_LogicalDiskToPartition, // 逻辑磁盘所在分区及始末位置。
            Win32_LogicalMemoryConfiguration, // 逻辑内存配置
            Win32_PageFile, // 系统页文件信息
            Win32_PageFileSetting, // 页文件设置
            Win32_BootConfiguration, // 系统启动配置
            Win32_ComputerSystem, // 计算机信息简要
            Win32_OperatingSystem, // 操作系统信息
            Win32_StartupCommand, // 系统自动启动程序
            Win32_Service, // 系统安装的服务
            Win32_Group, // 系统管理组
            Win32_GroupUser, // 系统组帐号
            Win32_UserAccount, // 用户帐号
            Win32_Process, // 系统进程
            Win32_Thread, // 系统线程
            Win32_Share, // 共享
            Win32_NetworkClient, // 已安装的网络客户端
            Win32_NetworkProtocol, // 已安装的网络协议
            Win32_PnPEntity,//all device
        }
        /// <summary>
        /// WMI取硬件信息
        /// </summary>
        /// <param name="hardType"></param>
        /// <param name="propKey"></param>
        /// <returns></returns>
        private static string[] GetHarewareInfo(HardwareEnum hardType, string propKey)
        {

            List<string> strs = new List<string>();
            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + hardType))
                {
                    var hardInfos = searcher.Get();
                    foreach (var hardInfo in hardInfos)
                    {
                        if (hardInfo.Properties[propKey].Value != null)
                        {
                            String str = hardInfo.Properties[propKey].Value.ToString();
                            if (str.Contains("(COM"))
                            {
                                strs.Add(str);
                            }
                        }
                    }
                }
                return strs.ToArray();
            }
            catch
            {
                MessageBox.Show("error");
                return null;
            }
            finally
            {
                strs = null;
            }
        }//end of func GetHarewareInfo().
         //通过WMI获取COM端口

        /// <summary>
        /// 设置控件状态
        /// </summary>
        private void setWidget(bool state)
        {
            OpenSerialButton.Enabled = state;
            BaudRateBox.Enabled = state;
            DataLenthBox.Enabled = state;
            ParityBox.Enabled = state;
            StopBitBox.Enabled = state;
            SerialPortBox.Enabled = state;
            EncodeBox.Enabled = state;
            checkBox_RXhex.Enabled = state;
            checkBox_TXhex.Enabled = state;
            checkBox_RegularlySend.Enabled = state;
            SendButton.Enabled = state;
            checkBox_loopback.Enabled = state;
            sendTime.Enabled = state;
        }

        /// <summary>
        /// 刷新串口设备
        /// </summary>
        private void RefreshCOMList()
        {
            setWidget(false);
            string[] str = GetHarewareInfo(HardwareEnum.Win32_PnPEntity, "Name");//获取全部驱动名称
            try
            {
                SerialPortBox.Items.Clear();//清除下拉菜单
                for (int i = 0; i < str.Length; i++)
                {
                    SerialPortBox.Items.Add(str[i]);//重新写入
                }
                //硬件改动时不改变原来选中的设备，如果选中设备被移除，则选中第一个
                //***********************************************start
                int j = 0;
                foreach (var i in SerialPortBox.Items)//检测选中设备是否存在于新列表
                {
                    if (i.ToString() == currentCOM)
                    {
                        break;
                    }
                    j++;
                }
                if (j < SerialPortBox.Items.Count)//如果存在则不改变设置
                {
                    SerialPortBox.SelectedIndex = j;
                    SerialPortBox.SelectedItem = currentCOM;
                }
                else                             //不存在则选中第一个   移除的为选中设备
                {
                    SerialPortBox.SelectedIndex = 0;
                    if (serialPort1.IsOpen == false)
                    {
                        serialPort1.Close();
                        setWidget(true);
                        SerialPortBox.Enabled = true;
                        OpenSerialButton.Text = "打开串口";
                    }
                }
                //***********************************************end
            }
            catch (Exception)
            {
                MessageBox.Show("没有可用端口", "提示");
            }
            if (serialPort1.IsOpen == false)
            {
                setWidget(true);
            }
            OpenSerialButton.Enabled = true;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_DEVICECHANGE = 0x219;
            if (m.Msg == WM_DEVICECHANGE)
            {
                timer1.Enabled = true;
            }
            base.WndProc(ref m); //将系统消息传递自父类的WndProc
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            RefreshCOMList();
        }
        private void SerialPortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCOM = SerialPortBox.SelectedItem.ToString();
        }










        
        private void Form1_Load(object sender, EventArgs e)
        {
            BaudRateBox.SelectedIndex = 3;
            DataLenthBox.SelectedIndex = 3;
            ParityBox.SelectedIndex = 0;
            StopBitBox.SelectedIndex = 0;
            RefreshCOMList();
            SerialPortBox.SelectedIndex = 0;
            EncodeBox.SelectedIndex = 0;
            DynamicByteProvider myIByteProviderRX = new DynamicByteProvider(new byte[0]);
            hexBoxTX.ByteProvider = myIByteProviderRX;
            DynamicByteProvider myIByteProviderTX = new DynamicByteProvider(new byte[0]);
            hexBoxRX.ByteProvider = myIByteProviderTX;
            textBox_TX.Show();
            textBox_RX.Show();
            hexBoxRX.Hide();
            hexBoxTX.Hide();
        }
        int encodeBoxIndex=0;
        bool m_IsTryToClosePort;
        bool m_IsReceiving;
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (serialPort1.IsOpen == false)
            {
                int startIndex, endIndex;
                startIndex = SerialPortBox.SelectedItem.ToString().LastIndexOf("(");
                endIndex = SerialPortBox.SelectedItem.ToString().LastIndexOf(")");
                string comPortName = SerialPortBox.SelectedItem.ToString().Substring(startIndex + 1, endIndex - startIndex - 1);
                //设置串口属性
                serialPort1.StopBits = stopBitsArr[StopBitBox.SelectedIndex];
                serialPort1.Parity = parityArr[ParityBox.SelectedIndex];
                serialPort1.BaudRate = baudRateArr[BaudRateBox.SelectedIndex];
                serialPort1.DataBits = dataLenthArr[DataLenthBox.SelectedIndex];
                serialPort1.PortName = comPortName;
                
                switch(encodeBoxIndex)
                {
                    case 0:serialPort1.Encoding = Encoding.Default;
                        break;
                    case 1:serialPort1.Encoding = Encoding.ASCII;
                        break;
                    case 2:serialPort1.Encoding = Encoding.Unicode;
                        break;
                    case 3:serialPort1.Encoding = Encoding.UTF7;
                        break;
                    case 4:serialPort1.Encoding = Encoding.UTF8;
                        break;
                    case 5:serialPort1.Encoding = Encoding.UTF32;
                        break;
                }
                try
                {
                    serialPort1.Open();//打开串口
                }
                catch
                {
                    MessageBox.Show("打开失败！");
                    return;
                }
                setWidget(true);
                OpenSerialButton.Enabled = false;
                BaudRateBox.Enabled = false;
                DataLenthBox.Enabled = false;
                ParityBox.Enabled = false;
                StopBitBox.Enabled = false;
                SerialPortBox.Enabled = false;
                EncodeBox.Enabled = false;
                checkBox_RegularlySend.Checked = false;
                OpenSerialButton.Enabled = true;
                OpenSerialButton.Text = "关闭串口";
            }
            else
            {
                m_IsTryToClosePort = true;//防止关闭串口时死机
                while (m_IsReceiving)
                {
                    System.Windows.Forms.Application.DoEvents();//防止关闭串口时死机
                }
                serialPort1.Close();
                setWidget(true);
                timer2.Enabled = checkBox_RegularlySend.Checked = false;
                timer2.Interval = Convert.ToInt32(sendTime.Value);
                OpenSerialButton.Text = "打开串口";
            }
        }

        private void checkBox_TXhex_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox_TXhex.Checked == true)
            {
                textBox_TX.Hide();
                hexBoxTX.Show();
            } 
            else
            {
                textBox_TX.Show();
                hexBoxTX.Hide();
            }
        }

        private void checkBox_RXhex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_RXhex.Checked == true)
            {
                textBox_RX.Hide();
                hexBoxRX.Show();
            }
            else
            {
                textBox_RX.Show();
                hexBoxRX.Hide();
            }
        }
        /// <summary>
        /// 串口发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //发送文本
            if (textBox_TX.Text != null && serialPort1.IsOpen && checkBox_TXhex.Checked == false)
            {
                serialPort1.Write(textBox_TX.Text);
                //serialPort1.
            }
            else if(serialPort1.IsOpen && checkBox_TXhex.Checked == true)
            {
                byte[] btss;
                btss = hexBoxTX.GetBytes();
                serialPort1.Write(hexBoxTX.GetBytes().ToArray(), 0, hexBoxTX.GetBytes().Length);
            }
            //发送HEX
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if(m_IsTryToClosePort)//防止关闭串口时死机
            {
                return;
            }
            m_IsReceiving = true;//防止关闭串口时死机
            try
            {
                if (serialPort1.IsOpen == true)
                {
                    int num = serialPort1.BytesToRead;
                    byte[] dat = new byte[num];
                    serialPort1.Read(dat, 0, num);
                    //显示字符串
                    switch (encodeBoxIndex)
                    {
                        case 0:
                            SetText(textBox_RX.Text + System.Text.Encoding.Default.GetString(dat));
                            break;
                        case 1:
                            SetText(textBox_RX.Text + System.Text.Encoding.ASCII.GetString(dat));
                            break;
                        case 2:
                            SetText(textBox_RX.Text + System.Text.Encoding.Unicode.GetString(dat));
                            break;
                        case 3:
                            SetText(textBox_RX.Text + System.Text.Encoding.UTF7.GetString(dat));
                            break;
                        case 4:
                            SetText(textBox_RX.Text + System.Text.Encoding.UTF8.GetString(dat));
                            break;
                        case 5:
                            SetText(textBox_RX.Text + System.Text.Encoding.UTF32.GetString(dat));
                            break;
                    }

                    //显示hex
                    hexBoxRX.AddData(dat);
                    if (checkBox_loopback.Checked == true)
                    {
                        serialPort1.Write(dat.ToArray(), 0, dat.Length);
                    }
                }
            }
            finally { m_IsReceiving = false; }//防止关闭串口时死机
        }
        /// <summary>
        /// 设置定时发送时间，开启关闭自动发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_RegularlySend_CheckedChanged(object sender, EventArgs e)
        {
            timer2.Interval = Convert.ToInt32(sendTime.Value);
            timer2.Enabled = checkBox_RegularlySend.Checked;
        }
        /// <summary>
        /// 定时发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = Convert.ToInt32(sendTime.Value);
            if (textBox_TX.Text != null && serialPort1.IsOpen && checkBox_TXhex.Checked == false)
            {
                serialPort1.Write(textBox_TX.Text);
            }
            else if (serialPort1.IsOpen && checkBox_TXhex.Checked == true)
            {
                byte[] btss;
                btss = hexBoxTX.GetBytes();
                serialPort1.Write(hexBoxTX.GetBytes().ToArray(), 0, hexBoxTX.GetBytes().Length);
            }
            
        }

        private void clearRXButton_Click(object sender, EventArgs e)
        {
            textBox_RX.Text = "";
            hexBoxRX.Clear();
        }

        private void clearTXButton_Click(object sender, EventArgs e)
        {
            textBox_TX.Text = "";
            hexBoxTX.Clear();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetHexPerLine(hexBoxRX.Size.Width / 44);
        }

        private void EncodeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            encodeBoxIndex = EncodeBox.SelectedIndex;
        }
    }
}
