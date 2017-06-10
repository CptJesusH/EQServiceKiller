using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.ServiceProcess;

namespace EQ_Service_Killer_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void spooler_Status_Click(object sender, EventArgs e)
        {
            textBox1.Text = EQServices.GetStatus(0);
            textBox2.Text = EQServices.GetStatus(1);
            textBox3.Text = EQServices.GetStatus(2);
            textBox4.Text = EQServices.GetStatus(3);
            textBox5.Text = EQServices.GetStatus(4);
            textBox6.Text = EQServices.GetStatus(5);
        }
        private void startServiceButton_Click(object sender, EventArgs e)
        {
            EQServices.StartCheckedServices();
        }
        private void stopServiceButton_Click(object sender, EventArgs e)
        {
            EQServices.StopCheckedServices();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Check Boxes
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            spoolerCheckBox.Checked = true;
            htcCheckBox.Checked = true;
            originCheckBox.Checked = true;
            pingCheckBox.Checked = true;
            razerCheckBox.Checked = true;
            ssuCheckBox.Checked = true;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            spoolerCheckBox.Checked = false;
            htcCheckBox.Checked = false;
            originCheckBox.Checked = false;
            pingCheckBox.Checked = false;
            razerCheckBox.Checked = false;
            ssuCheckBox.Checked = false;
        }
        private void spoolerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EQServices.Checked(0);
        }
        private void htcCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EQServices.Checked(1);
        }
        private void originCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EQServices.Checked(2);
        }
        private void pingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EQServices.Checked(3);
        }
        private void razerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EQServices.Checked(4);
        }
        private void ssuCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EQServices.Checked(5);
        }
        #endregion

        
    }
}
