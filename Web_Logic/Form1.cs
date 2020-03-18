﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Web_Logic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Общ.инф.
        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = PcGenInfo.GetComputerName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = PcGenInfo.GetAccountName();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = PcGenInfo.GetKeyboardName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = PcGenInfo.GetKeyboardDescription();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = PcGenInfo.GetMACAddress();
        }

        //Процессор
        private void button6_Click(object sender, EventArgs e)
        {
            label6.Text = Processor.GetProcessorInformation();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label7.Text = Processor.GetProcessorDescription();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label8.Text = Processor.GetProcessorNumberOfCores();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label9.Text = Processor.GetProcessorThreadCount();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label10.Text = Processor.GetProcessorCurrentClockSpeed();
        }

        //Диски
        private void button16_Click(object sender, EventArgs e)
        {
            label16.Text = Disks.GetHDDSerialNo();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label17.Text = Disks.GetDriveName();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label18.Text = Disks.GetDriveBlockSize();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label19.Text = Disks.GetCdRomDrive();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label20.Text = Disks.GetDriveFreeSize();
            label21.Text = Disks.GetDriveSize();
        }
    }
}
