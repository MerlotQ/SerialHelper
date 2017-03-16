namespace SerialHelper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StopBitBox = new System.Windows.Forms.ComboBox();
            this.ParityBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataLenthBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BaudRateBox = new System.Windows.Forms.ComboBox();
            this.OpenSerialButton = new System.Windows.Forms.Button();
            this.SerialPortBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.checkBox_TXhex = new System.Windows.Forms.CheckBox();
            this.checkBox_RXhex = new System.Windows.Forms.CheckBox();
            this.textBox_TX = new System.Windows.Forms.TextBox();
            this.textBox_RX = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.sendTime = new System.Windows.Forms.NumericUpDown();
            this.checkBox_RegularlySend = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.clearRXButton = new System.Windows.Forms.Button();
            this.clearTXButton = new System.Windows.Forms.Button();
            this.checkBox_loopback = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EncodeBox = new System.Windows.Forms.ComboBox();
            this.checkBox_sendNewLine = new System.Windows.Forms.CheckBox();
            this.hexBoxTX = new Be.Windows.Forms.HexBox();
            this.hexBoxRX = new Be.Windows.Forms.HexBox();
            ((System.ComponentModel.ISupportInitialize)(this.sendTime)).BeginInit();
            this.SuspendLayout();
            // 
            // StopBitBox
            // 
            this.StopBitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitBox.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.StopBitBox.FormattingEnabled = true;
            this.StopBitBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "无"});
            this.StopBitBox.Location = new System.Drawing.Point(357, 19);
            this.StopBitBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StopBitBox.Name = "StopBitBox";
            this.StopBitBox.Size = new System.Drawing.Size(81, 36);
            this.StopBitBox.TabIndex = 35;
            // 
            // ParityBox
            // 
            this.ParityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityBox.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.ParityBox.FormattingEnabled = true;
            this.ParityBox.Items.AddRange(new object[] {
            "无",
            "0校验",
            "1校验",
            "奇校验",
            "偶校验"});
            this.ParityBox.Location = new System.Drawing.Point(121, 16);
            this.ParityBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ParityBox.Name = "ParityBox";
            this.ParityBox.Size = new System.Drawing.Size(111, 36);
            this.ParityBox.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label5.Location = new System.Drawing.Point(248, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "停止位:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "校验位:";
            // 
            // DataLenthBox
            // 
            this.DataLenthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataLenthBox.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.DataLenthBox.FormattingEnabled = true;
            this.DataLenthBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.DataLenthBox.Location = new System.Drawing.Point(357, 68);
            this.DataLenthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataLenthBox.Name = "DataLenthBox";
            this.DataLenthBox.Size = new System.Drawing.Size(81, 36);
            this.DataLenthBox.TabIndex = 31;
            this.DataLenthBox.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label3.Location = new System.Drawing.Point(248, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "数据位:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label2.Location = new System.Drawing.Point(575, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "端口:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "波特率:";
            // 
            // BaudRateBox
            // 
            this.BaudRateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateBox.FormattingEnabled = true;
            this.BaudRateBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.BaudRateBox.Location = new System.Drawing.Point(121, 68);
            this.BaudRateBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BaudRateBox.Name = "BaudRateBox";
            this.BaudRateBox.Size = new System.Drawing.Size(111, 36);
            this.BaudRateBox.TabIndex = 27;
            // 
            // OpenSerialButton
            // 
            this.OpenSerialButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSerialButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenSerialButton.Location = new System.Drawing.Point(1180, 19);
            this.OpenSerialButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenSerialButton.Name = "OpenSerialButton";
            this.OpenSerialButton.Size = new System.Drawing.Size(100, 38);
            this.OpenSerialButton.TabIndex = 26;
            this.OpenSerialButton.Text = "打开串口";
            this.OpenSerialButton.UseVisualStyleBackColor = false;
            this.OpenSerialButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SerialPortBox
            // 
            this.SerialPortBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialPortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerialPortBox.Font = new System.Drawing.Font("Consolas", 14F);
            this.SerialPortBox.FormattingEnabled = true;
            this.SerialPortBox.Location = new System.Drawing.Point(659, 20);
            this.SerialPortBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SerialPortBox.Name = "SerialPortBox";
            this.SerialPortBox.Size = new System.Drawing.Size(512, 35);
            this.SerialPortBox.TabIndex = 36;
            this.SerialPortBox.TabStop = false;
            this.SerialPortBox.SelectedIndexChanged += new System.EventHandler(this.SerialPortBox_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // checkBox_TXhex
            // 
            this.checkBox_TXhex.AutoSize = true;
            this.checkBox_TXhex.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_TXhex.Font = new System.Drawing.Font("宋体", 14.25F);
            this.checkBox_TXhex.Location = new System.Drawing.Point(16, 122);
            this.checkBox_TXhex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_TXhex.Name = "checkBox_TXhex";
            this.checkBox_TXhex.Size = new System.Drawing.Size(116, 28);
            this.checkBox_TXhex.TabIndex = 37;
            this.checkBox_TXhex.Text = "HEX发送";
            this.checkBox_TXhex.UseVisualStyleBackColor = false;
            this.checkBox_TXhex.CheckedChanged += new System.EventHandler(this.checkBox_TXhex_CheckedChanged);
            // 
            // checkBox_RXhex
            // 
            this.checkBox_RXhex.AutoSize = true;
            this.checkBox_RXhex.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_RXhex.Font = new System.Drawing.Font("宋体", 14.25F);
            this.checkBox_RXhex.Location = new System.Drawing.Point(16, 158);
            this.checkBox_RXhex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_RXhex.Name = "checkBox_RXhex";
            this.checkBox_RXhex.Size = new System.Drawing.Size(116, 28);
            this.checkBox_RXhex.TabIndex = 38;
            this.checkBox_RXhex.Text = "HEX接收";
            this.checkBox_RXhex.UseVisualStyleBackColor = false;
            this.checkBox_RXhex.CheckedChanged += new System.EventHandler(this.checkBox_RXhex_CheckedChanged);
            // 
            // textBox_TX
            // 
            this.textBox_TX.AcceptsReturn = true;
            this.textBox_TX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_TX.Font = new System.Drawing.Font("宋体", 14.25F);
            this.textBox_TX.Location = new System.Drawing.Point(16, 244);
            this.textBox_TX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_TX.Multiline = true;
            this.textBox_TX.Name = "textBox_TX";
            this.textBox_TX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_TX.Size = new System.Drawing.Size(540, 280);
            this.textBox_TX.TabIndex = 40;
            // 
            // textBox_RX
            // 
            this.textBox_RX.AcceptsReturn = true;
            this.textBox_RX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_RX.Font = new System.Drawing.Font("宋体", 14.25F);
            this.textBox_RX.Location = new System.Drawing.Point(580, 73);
            this.textBox_RX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_RX.Multiline = true;
            this.textBox_RX.Name = "textBox_RX";
            this.textBox_RX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_RX.Size = new System.Drawing.Size(697, 452);
            this.textBox_RX.TabIndex = 41;
            this.textBox_RX.TextChanged += new System.EventHandler(this.textBox_RX_TextChanged);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.Transparent;
            this.SendButton.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendButton.Location = new System.Drawing.Point(319, 166);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(239, 62);
            this.SendButton.TabIndex = 42;
            this.SendButton.Text = "发送";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // sendTime
            // 
            this.sendTime.Font = new System.Drawing.Font("宋体", 14.25F);
            this.sendTime.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.sendTime.Location = new System.Drawing.Point(163, 193);
            this.sendTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendTime.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.sendTime.Name = "sendTime";
            this.sendTime.Size = new System.Drawing.Size(141, 35);
            this.sendTime.TabIndex = 44;
            this.sendTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // checkBox_RegularlySend
            // 
            this.checkBox_RegularlySend.AutoSize = true;
            this.checkBox_RegularlySend.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_RegularlySend.Font = new System.Drawing.Font("宋体", 14.25F);
            this.checkBox_RegularlySend.Location = new System.Drawing.Point(167, 158);
            this.checkBox_RegularlySend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_RegularlySend.Name = "checkBox_RegularlySend";
            this.checkBox_RegularlySend.Size = new System.Drawing.Size(128, 28);
            this.checkBox_RegularlySend.TabIndex = 46;
            this.checkBox_RegularlySend.Text = "定时发送";
            this.checkBox_RegularlySend.UseVisualStyleBackColor = false;
            this.checkBox_RegularlySend.CheckedChanged += new System.EventHandler(this.checkBox_RegularlySend_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // clearRXButton
            // 
            this.clearRXButton.BackColor = System.Drawing.Color.Transparent;
            this.clearRXButton.Location = new System.Drawing.Point(457, 19);
            this.clearRXButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearRXButton.Name = "clearRXButton";
            this.clearRXButton.Size = new System.Drawing.Size(100, 40);
            this.clearRXButton.TabIndex = 47;
            this.clearRXButton.Text = "清空接收区";
            this.clearRXButton.UseVisualStyleBackColor = false;
            this.clearRXButton.Click += new System.EventHandler(this.clearRXButton_Click);
            // 
            // clearTXButton
            // 
            this.clearTXButton.BackColor = System.Drawing.Color.Transparent;
            this.clearTXButton.Location = new System.Drawing.Point(457, 68);
            this.clearTXButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearTXButton.Name = "clearTXButton";
            this.clearTXButton.Size = new System.Drawing.Size(100, 40);
            this.clearTXButton.TabIndex = 48;
            this.clearTXButton.Text = "清空发送区";
            this.clearTXButton.UseVisualStyleBackColor = false;
            this.clearTXButton.Click += new System.EventHandler(this.clearTXButton_Click);
            // 
            // checkBox_loopback
            // 
            this.checkBox_loopback.AutoSize = true;
            this.checkBox_loopback.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_loopback.Font = new System.Drawing.Font("宋体", 14.25F);
            this.checkBox_loopback.Location = new System.Drawing.Point(167, 122);
            this.checkBox_loopback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_loopback.Name = "checkBox_loopback";
            this.checkBox_loopback.Size = new System.Drawing.Size(128, 28);
            this.checkBox_loopback.TabIndex = 49;
            this.checkBox_loopback.Text = "回环测试";
            this.checkBox_loopback.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label6.Location = new System.Drawing.Point(313, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 50;
            this.label6.Text = "编码:";
            // 
            // EncodeBox
            // 
            this.EncodeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodeBox.Font = new System.Drawing.Font("Consolas", 14F);
            this.EncodeBox.FormattingEnabled = true;
            this.EncodeBox.Items.AddRange(new object[] {
            "Default",
            "ASCII",
            "Unicode",
            "UTF7",
            "UTF8",
            "UTF32"});
            this.EncodeBox.Location = new System.Drawing.Point(397, 116);
            this.EncodeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EncodeBox.Name = "EncodeBox";
            this.EncodeBox.Size = new System.Drawing.Size(159, 35);
            this.EncodeBox.TabIndex = 51;
            this.EncodeBox.SelectedIndexChanged += new System.EventHandler(this.EncodeBox_SelectedIndexChanged);
            // 
            // checkBox_sendNewLine
            // 
            this.checkBox_sendNewLine.AutoSize = true;
            this.checkBox_sendNewLine.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_sendNewLine.Font = new System.Drawing.Font("宋体", 14.25F);
            this.checkBox_sendNewLine.Location = new System.Drawing.Point(16, 194);
            this.checkBox_sendNewLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_sendNewLine.Name = "checkBox_sendNewLine";
            this.checkBox_sendNewLine.Size = new System.Drawing.Size(128, 28);
            this.checkBox_sendNewLine.TabIndex = 52;
            this.checkBox_sendNewLine.Text = "发送新行";
            this.checkBox_sendNewLine.UseVisualStyleBackColor = false;
            // 
            // hexBoxTX
            // 
            this.hexBoxTX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hexBoxTX.BytesPerLine = 8;
            this.hexBoxTX.Font = new System.Drawing.Font("Consolas", 14F);
            this.hexBoxTX.LineInfoForeColor = System.Drawing.Color.Empty;
            this.hexBoxTX.Location = new System.Drawing.Point(16, 244);
            this.hexBoxTX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hexBoxTX.Name = "hexBoxTX";
            this.hexBoxTX.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBoxTX.Size = new System.Drawing.Size(541, 281);
            this.hexBoxTX.StringViewVisible = true;
            this.hexBoxTX.TabIndex = 0;
            this.hexBoxTX.UseFixedBytesPerLine = true;
            this.hexBoxTX.VScrollBarVisible = true;
            // 
            // hexBoxRX
            // 
            this.hexBoxRX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexBoxRX.BytesPerLine = 10;
            this.hexBoxRX.Font = new System.Drawing.Font("Consolas", 12F);
            this.hexBoxRX.LineInfoForeColor = System.Drawing.Color.Empty;
            this.hexBoxRX.Location = new System.Drawing.Point(580, 73);
            this.hexBoxRX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hexBoxRX.Name = "hexBoxRX";
            this.hexBoxRX.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBoxRX.Size = new System.Drawing.Size(700, 452);
            this.hexBoxRX.StringViewVisible = true;
            this.hexBoxRX.TabIndex = 39;
            this.hexBoxRX.UseFixedBytesPerLine = true;
            this.hexBoxRX.VScrollBarVisible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 570);
            this.Controls.Add(this.checkBox_sendNewLine);
            this.Controls.Add(this.EncodeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox_loopback);
            this.Controls.Add(this.clearTXButton);
            this.Controls.Add(this.clearRXButton);
            this.Controls.Add(this.checkBox_RegularlySend);
            this.Controls.Add(this.sendTime);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.checkBox_RXhex);
            this.Controls.Add(this.checkBox_TXhex);
            this.Controls.Add(this.StopBitBox);
            this.Controls.Add(this.ParityBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataLenthBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BaudRateBox);
            this.Controls.Add(this.OpenSerialButton);
            this.Controls.Add(this.SerialPortBox);
            this.Controls.Add(this.textBox_RX);
            this.Controls.Add(this.textBox_TX);
            this.Controls.Add(this.hexBoxTX);
            this.Controls.Add(this.hexBoxRX);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "串口助手  --by浙江师范大学陈竞远";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.sendTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Be.Windows.Forms.HexBox hexBoxTX;
        private System.Windows.Forms.ComboBox StopBitBox;
        private System.Windows.Forms.ComboBox ParityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DataLenthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BaudRateBox;
        private System.Windows.Forms.Button OpenSerialButton;
        private System.Windows.Forms.ComboBox SerialPortBox;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox checkBox_TXhex;
        private System.Windows.Forms.CheckBox checkBox_RXhex;
        private Be.Windows.Forms.HexBox hexBoxRX;
        private System.Windows.Forms.TextBox textBox_TX;
        private System.Windows.Forms.TextBox textBox_RX;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.NumericUpDown sendTime;
        private System.Windows.Forms.CheckBox checkBox_RegularlySend;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button clearRXButton;
        private System.Windows.Forms.Button clearTXButton;
        private System.Windows.Forms.CheckBox checkBox_loopback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EncodeBox;
        private System.Windows.Forms.CheckBox checkBox_sendNewLine;
    }
}

