﻿namespace DCtoDCBuckConverter
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
            this.cBoxSetOutputByTrackbar = new System.Windows.Forms.ComboBox();
            this.tBarSetCurrentLimit = new System.Windows.Forms.TrackBar();
            this.tBarSetTargetVoltage = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.chBoxSendAutomatically = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSetCurrentLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSetTargetVoltage)).BeginInit();
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
            "none",
            "odd",
            "even"});
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
            this.groupBox3.Size = new System.Drawing.Size(329, 210);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send by text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 169);
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
            this.tBoxSendData.Size = new System.Drawing.Size(296, 135);
            this.tBoxSendData.TabIndex = 1;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(16, 169);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(103, 23);
            this.btnSendData.TabIndex = 0;
            this.btnSendData.Text = "->send data";
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
            // 
            // tBoxReceiveData
            // 
            this.tBoxReceiveData.Location = new System.Drawing.Point(16, 28);
            this.tBoxReceiveData.Multiline = true;
            this.tBoxReceiveData.Name = "tBoxReceiveData";
            this.tBoxReceiveData.ReadOnly = true;
            this.tBoxReceiveData.Size = new System.Drawing.Size(296, 205);
            this.tBoxReceiveData.TabIndex = 1;
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
            this.groupBox5.Size = new System.Drawing.Size(329, 173);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Send by uploading values";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "[mA]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "[mV]";
            // 
            // tBoxSetCurrentLimit
            // 
            this.tBoxSetCurrentLimit.Location = new System.Drawing.Point(145, 62);
            this.tBoxSetCurrentLimit.Name = "tBoxSetCurrentLimit";
            this.tBoxSetCurrentLimit.Size = new System.Drawing.Size(126, 22);
            this.tBoxSetCurrentLimit.TabIndex = 8;
            // 
            // tBoxSetTargetValue
            // 
            this.tBoxSetTargetValue.Location = new System.Drawing.Point(145, 29);
            this.tBoxSetTargetValue.Name = "tBoxSetTargetValue";
            this.tBoxSetTargetValue.Size = new System.Drawing.Size(126, 22);
            this.tBoxSetTargetValue.TabIndex = 5;
            // 
            // btnSendDataByValues
            // 
            this.btnSendDataByValues.Location = new System.Drawing.Point(16, 139);
            this.btnSendDataByValues.Name = "btnSendDataByValues";
            this.btnSendDataByValues.Size = new System.Drawing.Size(103, 23);
            this.btnSendDataByValues.TabIndex = 3;
            this.btnSendDataByValues.Text = "->send data";
            this.btnSendDataByValues.UseVisualStyleBackColor = true;
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
            this.cBoxSetOutputByValues.Size = new System.Drawing.Size(167, 24);
            this.cBoxSetOutputByValues.TabIndex = 6;
            this.cBoxSetOutputByValues.Text = "-";
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
            this.groupBox6.Controls.Add(this.cBoxSetOutputByTrackbar);
            this.groupBox6.Controls.Add(this.tBarSetCurrentLimit);
            this.groupBox6.Controls.Add(this.tBarSetTargetVoltage);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.chBoxSendAutomatically);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(363, 425);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(329, 249);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Send with TrackBar";
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
            this.cBoxSetOutputByTrackbar.Text = "-";
            // 
            // tBarSetCurrentLimit
            // 
            this.tBarSetCurrentLimit.Location = new System.Drawing.Point(167, 83);
            this.tBarSetCurrentLimit.Name = "tBarSetCurrentLimit";
            this.tBarSetCurrentLimit.Size = new System.Drawing.Size(104, 56);
            this.tBarSetCurrentLimit.TabIndex = 15;
            // 
            // tBarSetTargetVoltage
            // 
            this.tBarSetTargetVoltage.Location = new System.Drawing.Point(167, 21);
            this.tBarSetTargetVoltage.Name = "tBarSetTargetVoltage";
            this.tBarSetTargetVoltage.Size = new System.Drawing.Size(104, 56);
            this.tBarSetTargetVoltage.TabIndex = 14;
            this.tBarSetTargetVoltage.Scroll += new System.EventHandler(this.trackBar1_Scroll);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "->send data";
            this.button3.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 686);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
    }
}

