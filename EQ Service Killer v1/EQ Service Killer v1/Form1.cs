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
            ServiceController[] scServices;
            scServices = ServiceController.GetServices();

            foreach (ServiceController service in scServices)
            {
                if (service.ServiceName == "Spooler")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        ServiceController sc = new ServiceController("Spooler");
                        textBox1.Text = sc.Status.ToString();
                    }
                }
            }
        }

        private void startServiceButton_Click(object sender, EventArgs e)
        {
            ServiceStartStop("start");
        }

        private void stopServiceButton_Click(object sender, EventArgs e)
        {
            ServiceStartStop("stop");
        }

        public void ServiceStartStop(string startOrStop)
        {
            ServiceController[] scServices;
            scServices = ServiceController.GetServices();

            if (startOrStop == "stop")
            {
                foreach (ServiceController service in scServices)
                {
                    if (service.ServiceName == "Spooler")
                    {
                        ServiceController sc = new ServiceController("Spooler");
                        sc.Stop();
                        textBox1.Text = sc.Status.ToString();
                    }
                }
            }
            else if (startOrStop == "start")
            {
                foreach (ServiceController service in scServices)
                {
                    if (service.ServiceName == "Spooler")
                    {
                        ServiceController sc = new ServiceController("Spooler");
                        sc.Start();
                        textBox1.Text = sc.Status.ToString();
                    }
                }
            }
        }

        
    }
}
