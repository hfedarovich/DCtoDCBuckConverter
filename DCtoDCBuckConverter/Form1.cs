﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace DCtoDCBuckConverter
{
    public partial class Form1 : Form
    {
        string senddata;
        string receivedata;
        public Form1()
        {
            InitializeComponent();
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
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                senddata = tBoxSendData.Text;
                serialPort1.Write(senddata);
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
            receivedata = serialPort1.ReadExisting();
            //this methode is for showing the data in textbox
            this.Invoke(new EventHandler(ShowData));
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
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
