using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// add a reference to System.ServiceProcess.dll
using System.ServiceProcess;

namespace Service_is_installed_or_not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceController ctl = ServiceController.GetServices()
    .FirstOrDefault(s => s.ServiceName == "DNS Client");
            if (ctl == null)
                //Console.WriteLine("Not installed");
                textBox1.Text = "not";
            else
                //Console.WriteLine(ctl.Status);
                textBox1.Text = ctl.Status.ToString();
        }
    }
}
