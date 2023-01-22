using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DCtoDCBuckConverter
{
    public partial class Form1 : Form
    {
        string senddata;
        string senddata_old;
        string receivedata;
        string Voltage;
        string TargetVoltage;
        string Current;
        string CurrentLimit;
        string OutputMode;
        string Output = "off";
        bool graph = true;
        bool print = true;

        private int _countseconds = 0;

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPort.Items.AddRange(ports);
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            btnSendData.Enabled = true;
            btnSendDataByValues.Enabled = true;
            btnSendDataByTrackBar.Enabled = true;

            

            



        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                //COM PORT parameters
                serialPort1.PortName = cBoxCOMPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text); ;
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParity.Text);

                serialPort1.Open();
                progressBar1.Value = 100;

                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                lblstatus.Text = "connected";

                timer.Enabled = true;

                chart1.ChartAreas[0].AxisY.Maximum = 100;
                chart1.ChartAreas[0].AxisY.Minimum = -5;

                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
                chart1.Series[0].XValueType = ChartValueType.DateTime;

                chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate(); ;
                chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart1.ChartAreas[0].AxisX.Interval = 5;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblstatus.Text = "disconnected";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblstatus.Text = "disconnected";
                timer.Enabled = false;
                chart1.ChartAreas[0].AxisY.Maximum = 100;
                chart1.ChartAreas[0].AxisY.Minimum = -5;

                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
                chart1.Series[0].XValueType = ChartValueType.DateTime;

                chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate(); ;
                chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart1.ChartAreas[0].AxisX.Interval = 5;
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                senddata = tBoxSendData.Text;
                serialPort1.Write(senddata);
            }
            else
            {
                MessageBox.Show("you need to connect to a serial port first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tBoxSendData.Text != "")
            {
                tBoxSendData.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (tBoxReceiveData.Text != "")
            {
                tBoxReceiveData.Text = "";
            }
        }

        private void tBoxReceiveData_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            receivedata = serialPort1.ReadExisting();
            if (receivedata != "")
            {

                //this methode is for showing the data in textbox
                this.Invoke(new EventHandler(ShowData));
            }
            
        }
        private void ShowData(object sender, EventArgs e)
        {

            if (chBoxUpdate.Checked)
            {
                tBoxReceiveData.Text = receivedata;
            }
            else
            {
                tBoxReceiveData.Text += receivedata;
            }

            Int32 count = 8;
            
            string[] separator = { "{\"Voltage\": ", ",\"Current\": ", ",\"TargetVoltage\": ", ",\"CurrentLimit\": ", ",\"OutputMode\": \"", "\",\"Output\": \"", "\"}" };
            string[] datalist = receivedata.Split(separator, count, StringSplitOptions.None);

            Voltage = datalist[1];
            Current = datalist[2];
            TargetVoltage = datalist[3];
            CurrentLimit = datalist[4];
            OutputMode = datalist[5];
            Output = datalist[6];

            lblvoltage.Text = "Voltage: "+Voltage;
            lbltargetvoltage.Text = "TargetVoltage: " + TargetVoltage;
            lblcurrent.Text = "Current: " + Current;
            lblcurrentlimit.Text = "CurrentLimit: " + CurrentLimit;
            lbloutputmode.Text = "OutputMode: " + OutputMode;
            lbloutput.Text = "Output: " + Output;


        }


        private void tBoxSetTargetValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxSetTargetValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void tBoxSetCurrentLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show( "please enter digits only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void btnSendDataByValues_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                senddata = "{\"SetTargetVoltage\": " + Convert.ToInt32(tBoxSetTargetValue.Text) + ",\"SetCurrentLimit\": " + Convert.ToInt32(tBoxSetCurrentLimit.Text) + ",\"SetOutput\": \"" + cBoxSetOutputByValues.Text + "\"}";
                serialPort1.Write(senddata);
            }
            else
            {
                MessageBox.Show("you need to connect to a serial port first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tBarSetTargetVoltage_Scroll(object sender, EventArgs e)
        {
            tBoxtargetVoltage.Text = tBarSetTargetVoltage.Value.ToString();
        }

        private void tBoxtargetVoltage_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tBoxCurrentLimit_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBarSetCurrentLimit_Scroll(object sender, EventArgs e)
        {
            tBoxCurrentLimit.Text = tBarSetCurrentLimit.Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                senddata = "{\"SetTargetVoltage\": " + Convert.ToInt32(tBoxtargetVoltage.Text) + ",\"SetCurrentLimit\": " + Convert.ToInt32(tBoxCurrentLimit.Text) + ",\"SetOutput\": \"" + cBoxSetOutputByTrackbar.Text + "\"}";
                serialPort1.Write(senddata);
            }
            else 
            {
                MessageBox.Show("you need to connect to a serial port first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chBoxSendAutomatically_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxSendAutomatically.Checked && serialPort1.IsOpen)
            {
                btnSendData.Enabled = false;
                btnSendDataByValues.Enabled = false;
                btnSendDataByTrackBar.Enabled = false;
                senddata = "{\"SetTargetVoltage\": " + Convert.ToInt32(tBoxtargetVoltage.Text) + ",\"SetCurrentLimit\": " + Convert.ToInt32(tBoxCurrentLimit.Text) + ",\"SetOutput\": \"" + cBoxSetOutputByTrackbar.Text + "\"}";
                senddata_old=senddata;
                serialPort1.Write(senddata);

                while (chBoxSendAutomatically.Checked && serialPort1.IsOpen)
                {
                    btnSendData.Enabled = false;
                    btnSendDataByValues.Enabled = false;
                    btnSendDataByTrackBar.Enabled = false;
                    senddata_old = senddata;
                    senddata = "{\"SetTargetVoltage\": " + Convert.ToInt32(tBoxtargetVoltage.Text) + ",\"SetCurrentLimit\": " + Convert.ToInt32(tBoxCurrentLimit.Text) + ",\"SetOutput\": \"" + cBoxSetOutputByTrackbar.Text + "\"}";
                    if (senddata_old != senddata)
                    { 
                        serialPort1.Write(senddata);
                    }
                    wait(500);
                }
            }
            
            else if (chBoxSendAutomatically.Checked && !serialPort1.IsOpen)
            {
                btnSendData.Enabled = true;
                btnSendDataByValues.Enabled = true;
                btnSendDataByTrackBar.Enabled = true;
                chBoxSendAutomatically.Checked = false;
                MessageBox.Show("you need to connect to a serial port first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                btnSendData.Enabled = true;
                btnSendDataByValues.Enabled = true;
                btnSendDataByTrackBar.Enabled = true;
            }
        }



        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void time_1Tick(object sender, EventArgs e)
        {
            
            
        }

        private void btnStopGraph_Click(object sender, EventArgs e)
        {
            print = false;
        }

        private void btnContinueGraph_Click(object sender, EventArgs e)
        {
            print = true;
        }

        private void btnClearGraph_Click(object sender, EventArgs e)
        {
            _countseconds = 0;
            chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate(); ;
            chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.Interval = 5;
        }

        private void chBoxUpdate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                DateTime timeNow = DateTime.Now;
                Int32 valuevoltage = Convert.ToInt32(Voltage);
                Int32 valuecurrent = Convert.ToInt32(Current);
                Int32 valuetargetvoltage = Convert.ToInt32(TargetVoltage);
                Int32 valuecurrentlimit = Convert.ToInt32(CurrentLimit);
                if (print == true && Output == "on")
                {
                    chart1.Series[0].Points.AddXY(timeNow, valuevoltage);
                    chart1.Series[1].Points.AddXY(timeNow, valuecurrent);
                    chart1.Series[2].Points.AddXY(timeNow, valuetargetvoltage);
                    chart1.Series[3].Points.AddXY(timeNow, valuecurrentlimit);
                    if (_countseconds >= 60)
                    {
                        _countseconds = 0;
                        chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate(); ;
                        chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                        chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                        chart1.ChartAreas[0].AxisX.Interval = 5;

                    }
                }


                _countseconds++;


            }
        }
    }
}
/*
 
            if (datain != "")
            {
                
                string[] separator = { "{\"Voltage\": ", ",\"Current\": ", ",\"TargetVoltage\": ", ",\"CurrentLimit\": ", ",\"OutputMode\": \"", "\",\"Output\": \"", "\"}" };
                string[] datalist = datain.Split(separator, count, StringSplitOptions.None);
                //Voltage = Convert.ToInt32(datalist[1]);
                Voltage = datalist[1];
                //Current = Convert.ToInt32(datalist[2]);
                Current = datalist[2];
                //TargetVoltage = Convert.ToInt32(datalist[3]);
                TargetVoltage = datalist[3];
                //CurrentLimit = Convert.ToInt32(datalist[4]);
                CurrentLimit = datalist[4];
                OutputMode = datalist[5];
                Output = datalist[6];
                lblvoltage.Text = "Voltage: " + Current;
                
Voltage = datain;
lblvoltage.Text = Voltage;
            } 
  */