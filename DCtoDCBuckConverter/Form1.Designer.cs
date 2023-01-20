namespace DCtoDCBuckConverter
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tBoxSendData = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chBoxUpdate = new System.Windows.Forms.CheckBox();
            this.tBoxReceiveData = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tBoxSetCurrentLimit = new System.Windows.Forms.TextBox();
            this.tBoxSetTargetValue = new System.Windows.Forms.TextBox();
            this.btnSendDataByValues = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cBoxSetOutputByValues = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tBoxCurrentLimit = new System.Windows.Forms.TextBox();
            this.tBoxtargetVoltage = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cBoxSetOutputByTrackbar = new System.Windows.Forms.ComboBox();
            this.tBarSetCurrentLimit = new System.Windows.Forms.TrackBar();
            this.tBarSetTargetVoltage = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.chBoxSendAutomatically = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSendDataByTrackBar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnContinueGraph = new System.Windows.Forms.Button();
            this.btnClearGraph = new System.Windows.Forms.Button();
            this.btnStopGraph = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSetCurrentLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSetTargetVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cBoxParity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxCOMPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMPortControl";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cBoxParity
            // 
            this.cBoxParity.FormattingEnabled = true;
            this.cBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParity.Location = new System.Drawing.Point(152, 151);
            this.cBoxParity.Name = "cBoxParity";
            this.cBoxParity.Size = new System.Drawing.Size(149, 24);
            this.cBoxParity.TabIndex = 8;
            this.cBoxParity.Text = "-";
            this.cBoxParity.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "STOP BITS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cBoxStopBits.Location = new System.Drawing.Point(152, 121);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(149, 24);
            this.cBoxStopBits.TabIndex = 6;
            this.cBoxStopBits.Text = "-";
            this.cBoxStopBits.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "DATA BITS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(152, 91);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(149, 24);
            this.cBoxDataBits.TabIndex = 4;
            this.cBoxDataBits.Text = "-";
            this.cBoxDataBits.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "BOUD RATE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(152, 61);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(149, 24);
            this.cBoxBaudRate.TabIndex = 2;
            this.cBoxBaudRate.Text = "-";
            this.cBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM PORT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cBoxCOMPort
            // 
            this.cBoxCOMPort.FormattingEnabled = true;
            this.cBoxCOMPort.Location = new System.Drawing.Point(152, 31);
            this.cBoxCOMPort.Name = "cBoxCOMPort";
            this.cBoxCOMPort.Size = new System.Drawing.Size(149, 24);
            this.cBoxCOMPort.TabIndex = 0;
            this.cBoxCOMPort.Text = "-";
            this.cBoxCOMPort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblstatus);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(121, 103);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(88, 16);
            this.lblstatus.TabIndex = 4;
            this.lblstatus.Text = "disconnected";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(182, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "DISCONNECT";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 68);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(280, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(21, 21);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(125, 32);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "CONNECT";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.tBoxSendData);
            this.groupBox3.Controls.Add(this.btnSendData);
            this.groupBox3.Location = new System.Drawing.Point(363, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 210);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send by text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBoxSendData
            // 
            this.tBoxSendData.Location = new System.Drawing.Point(16, 28);
            this.tBoxSendData.Multiline = true;
            this.tBoxSendData.Name = "tBoxSendData";
            this.tBoxSendData.Size = new System.Drawing.Size(416, 135);
            this.tBoxSendData.TabIndex = 1;
            this.tBoxSendData.Text = "\"SetTargetVoltage\": x,\r\n  \"SetCurrentLimit\": x,\r\n  \"SetOutput\": \"x\"";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(16, 169);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(103, 23);
            this.btnSendData.TabIndex = 0;
            this.btnSendData.Text = "-> send data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chBoxUpdate);
            this.groupBox4.Controls.Add(this.tBoxReceiveData);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Location = new System.Drawing.Point(12, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 298);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receive";
            // 
            // chBoxUpdate
            // 
            this.chBoxUpdate.AutoSize = true;
            this.chBoxUpdate.Location = new System.Drawing.Point(211, 256);
            this.chBoxUpdate.Name = "chBoxUpdate";
            this.chBoxUpdate.Size = new System.Drawing.Size(101, 20);
            this.chBoxUpdate.TabIndex = 2;
            this.chBoxUpdate.Text = "auto-update";
            this.chBoxUpdate.UseVisualStyleBackColor = true;
            this.chBoxUpdate.CheckedChanged += new System.EventHandler(this.chBoxUpdate_CheckedChanged);
            // 
            // tBoxReceiveData
            // 
            this.tBoxReceiveData.Location = new System.Drawing.Point(16, 28);
            this.tBoxReceiveData.Multiline = true;
            this.tBoxReceiveData.Name = "tBoxReceiveData";
            this.tBoxReceiveData.ReadOnly = true;
            this.tBoxReceiveData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxReceiveData.Size = new System.Drawing.Size(296, 205);
            this.tBoxReceiveData.TabIndex = 1;
            this.tBoxReceiveData.Text = " ";
            this.tBoxReceiveData.TextChanged += new System.EventHandler(this.tBoxReceiveData_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(21, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.tBoxSetCurrentLimit);
            this.groupBox5.Controls.Add(this.tBoxSetTargetValue);
            this.groupBox5.Controls.Add(this.btnSendDataByValues);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cBoxSetOutputByValues);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(363, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(447, 173);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Send by uploading values";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "[mA]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "[mV]";
            // 
            // tBoxSetCurrentLimit
            // 
            this.tBoxSetCurrentLimit.Location = new System.Drawing.Point(145, 62);
            this.tBoxSetCurrentLimit.Name = "tBoxSetCurrentLimit";
            this.tBoxSetCurrentLimit.Size = new System.Drawing.Size(246, 22);
            this.tBoxSetCurrentLimit.TabIndex = 8;
            this.tBoxSetCurrentLimit.Text = "0";
            this.tBoxSetCurrentLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxSetCurrentLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxSetCurrentLimit_KeyPress);
            // 
            // tBoxSetTargetValue
            // 
            this.tBoxSetTargetValue.Location = new System.Drawing.Point(145, 29);
            this.tBoxSetTargetValue.Name = "tBoxSetTargetValue";
            this.tBoxSetTargetValue.Size = new System.Drawing.Size(246, 22);
            this.tBoxSetTargetValue.TabIndex = 5;
            this.tBoxSetTargetValue.Text = "0";
            this.tBoxSetTargetValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxSetTargetValue.TextChanged += new System.EventHandler(this.tBoxSetTargetValue_TextChanged);
            this.tBoxSetTargetValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxSetTargetValue_KeyPress);
            // 
            // btnSendDataByValues
            // 
            this.btnSendDataByValues.Location = new System.Drawing.Point(16, 139);
            this.btnSendDataByValues.Name = "btnSendDataByValues";
            this.btnSendDataByValues.Size = new System.Drawing.Size(103, 23);
            this.btnSendDataByValues.TabIndex = 3;
            this.btnSendDataByValues.Text = "-> send data";
            this.btnSendDataByValues.UseVisualStyleBackColor = true;
            this.btnSendDataByValues.Click += new System.EventHandler(this.btnSendDataByValues_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "SetOutput";
            // 
            // cBoxSetOutputByValues
            // 
            this.cBoxSetOutputByValues.FormattingEnabled = true;
            this.cBoxSetOutputByValues.Items.AddRange(new object[] {
            "on",
            "off"});
            this.cBoxSetOutputByValues.Location = new System.Drawing.Point(145, 92);
            this.cBoxSetOutputByValues.Name = "cBoxSetOutputByValues";
            this.cBoxSetOutputByValues.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBoxSetOutputByValues.Size = new System.Drawing.Size(246, 24);
            this.cBoxSetOutputByValues.TabIndex = 6;
            this.cBoxSetOutputByValues.Text = "off";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "SetCurrentLimit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "SetTargetVoltage";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tBoxCurrentLimit);
            this.groupBox6.Controls.Add(this.tBoxtargetVoltage);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.cBoxSetOutputByTrackbar);
            this.groupBox6.Controls.Add(this.tBarSetCurrentLimit);
            this.groupBox6.Controls.Add(this.tBarSetTargetVoltage);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.chBoxSendAutomatically);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.btnSendDataByTrackBar);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(363, 425);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(447, 249);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Send with TrackBar";
            // 
            // tBoxCurrentLimit
            // 
            this.tBoxCurrentLimit.Location = new System.Drawing.Point(280, 80);
            this.tBoxCurrentLimit.Name = "tBoxCurrentLimit";
            this.tBoxCurrentLimit.ReadOnly = true;
            this.tBoxCurrentLimit.Size = new System.Drawing.Size(100, 22);
            this.tBoxCurrentLimit.TabIndex = 19;
            this.tBoxCurrentLimit.Text = "0";
            this.tBoxCurrentLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxCurrentLimit.TextChanged += new System.EventHandler(this.tBoxCurrentLimit_TextChanged);
            // 
            // tBoxtargetVoltage
            // 
            this.tBoxtargetVoltage.Location = new System.Drawing.Point(280, 23);
            this.tBoxtargetVoltage.Name = "tBoxtargetVoltage";
            this.tBoxtargetVoltage.ReadOnly = true;
            this.tBoxtargetVoltage.Size = new System.Drawing.Size(100, 22);
            this.tBoxtargetVoltage.TabIndex = 18;
            this.tBoxtargetVoltage.Text = "0";
            this.tBoxtargetVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxtargetVoltage.TextChanged += new System.EventHandler(this.tBoxtargetVoltage_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(386, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "[mA]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(386, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "[mV]";
            // 
            // cBoxSetOutputByTrackbar
            // 
            this.cBoxSetOutputByTrackbar.FormattingEnabled = true;
            this.cBoxSetOutputByTrackbar.Items.AddRange(new object[] {
            "on",
            "off"});
            this.cBoxSetOutputByTrackbar.Location = new System.Drawing.Point(145, 145);
            this.cBoxSetOutputByTrackbar.Name = "cBoxSetOutputByTrackbar";
            this.cBoxSetOutputByTrackbar.Size = new System.Drawing.Size(167, 24);
            this.cBoxSetOutputByTrackbar.TabIndex = 11;
            this.cBoxSetOutputByTrackbar.Text = "off";
            // 
            // tBarSetCurrentLimit
            // 
            this.tBarSetCurrentLimit.LargeChange = 100;
            this.tBarSetCurrentLimit.Location = new System.Drawing.Point(167, 83);
            this.tBarSetCurrentLimit.Maximum = 1000;
            this.tBarSetCurrentLimit.Name = "tBarSetCurrentLimit";
            this.tBarSetCurrentLimit.Size = new System.Drawing.Size(104, 56);
            this.tBarSetCurrentLimit.SmallChange = 50;
            this.tBarSetCurrentLimit.TabIndex = 15;
            this.tBarSetCurrentLimit.Scroll += new System.EventHandler(this.tBarSetCurrentLimit_Scroll);
            // 
            // tBarSetTargetVoltage
            // 
            this.tBarSetTargetVoltage.LargeChange = 1000;
            this.tBarSetTargetVoltage.Location = new System.Drawing.Point(167, 21);
            this.tBarSetTargetVoltage.Maximum = 30000;
            this.tBarSetTargetVoltage.Name = "tBarSetTargetVoltage";
            this.tBarSetTargetVoltage.Size = new System.Drawing.Size(104, 56);
            this.tBarSetTargetVoltage.SmallChange = 500;
            this.tBarSetTargetVoltage.TabIndex = 14;
            this.tBarSetTargetVoltage.Scroll += new System.EventHandler(this.tBarSetTargetVoltage_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "SetOutput";
            // 
            // chBoxSendAutomatically
            // 
            this.chBoxSendAutomatically.AutoSize = true;
            this.chBoxSendAutomatically.Location = new System.Drawing.Point(182, 207);
            this.chBoxSendAutomatically.Name = "chBoxSendAutomatically";
            this.chBoxSendAutomatically.Size = new System.Drawing.Size(141, 20);
            this.chBoxSendAutomatically.TabIndex = 3;
            this.chBoxSendAutomatically.Text = "send automatically";
            this.chBoxSendAutomatically.UseVisualStyleBackColor = true;
            this.chBoxSendAutomatically.CheckedChanged += new System.EventHandler(this.chBoxSendAutomatically_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "SetCurrentLimit";
            // 
            // btnSendDataByTrackBar
            // 
            this.btnSendDataByTrackBar.Location = new System.Drawing.Point(16, 205);
            this.btnSendDataByTrackBar.Name = "btnSendDataByTrackBar";
            this.btnSendDataByTrackBar.Size = new System.Drawing.Size(103, 23);
            this.btnSendDataByTrackBar.TabIndex = 11;
            this.btnSendDataByTrackBar.Text = "-> send data";
            this.btnSendDataByTrackBar.UseVisualStyleBackColor = true;
            this.btnSendDataByTrackBar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "SetTargetVoltage";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 28);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Voltage";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Current";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(662, 506);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.time_1Tick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnContinueGraph);
            this.groupBox7.Controls.Add(this.btnClearGraph);
            this.groupBox7.Controls.Add(this.btnStopGraph);
            this.groupBox7.Controls.Add(this.chart1);
            this.groupBox7.Location = new System.Drawing.Point(827, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(695, 662);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Graph";
            // 
            // btnContinueGraph
            // 
            this.btnContinueGraph.Location = new System.Drawing.Point(241, 558);
            this.btnContinueGraph.Name = "btnContinueGraph";
            this.btnContinueGraph.Size = new System.Drawing.Size(209, 23);
            this.btnContinueGraph.TabIndex = 9;
            this.btnContinueGraph.Text = "CONTINUE";
            this.btnContinueGraph.UseVisualStyleBackColor = true;
            this.btnContinueGraph.Click += new System.EventHandler(this.btnContinueGraph_Click);
            // 
            // btnClearGraph
            // 
            this.btnClearGraph.Location = new System.Drawing.Point(468, 558);
            this.btnClearGraph.Name = "btnClearGraph";
            this.btnClearGraph.Size = new System.Drawing.Size(209, 23);
            this.btnClearGraph.TabIndex = 8;
            this.btnClearGraph.Text = "CLEAR";
            this.btnClearGraph.UseVisualStyleBackColor = true;
            this.btnClearGraph.Click += new System.EventHandler(this.btnClearGraph_Click);
            // 
            // btnStopGraph
            // 
            this.btnStopGraph.Location = new System.Drawing.Point(15, 558);
            this.btnStopGraph.Name = "btnStopGraph";
            this.btnStopGraph.Size = new System.Drawing.Size(209, 23);
            this.btnStopGraph.TabIndex = 7;
            this.btnStopGraph.Text = "STOP";
            this.btnStopGraph.UseVisualStyleBackColor = true;
            this.btnStopGraph.Click += new System.EventHandler(this.btnStopGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 686);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "DC_to_DC_Buck_Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSetCurrentLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSetTargetVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxCOMPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tBoxSendData;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tBoxReceiveData;
        private System.Windows.Forms.Button btnClear;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chBoxUpdate;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBoxSetCurrentLimit;
        private System.Windows.Forms.TextBox tBoxSetTargetValue;
        private System.Windows.Forms.Button btnSendDataByValues;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBoxSetOutputByValues;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cBoxSetOutputByTrackbar;
        private System.Windows.Forms.TrackBar tBarSetCurrentLimit;
        private System.Windows.Forms.TrackBar tBarSetTargetVoltage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chBoxSendAutomatically;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSendDataByTrackBar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBoxCurrentLimit;
        private System.Windows.Forms.TextBox tBoxtargetVoltage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnContinueGraph;
        private System.Windows.Forms.Button btnClearGraph;
        private System.Windows.Forms.Button btnStopGraph;
    }
}

