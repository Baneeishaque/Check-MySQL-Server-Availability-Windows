using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Management.Instrumentation;
using System.Management;

namespace Program_installed_or_not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        //Console.WriteLine(sk.GetValue("DisplayName"));
                        richTextBox1.Text = richTextBox1.Text + sk.GetValue("DisplayName") + "\n";
                    }
                }
            }

            //string uninstallKey = @"SYSTEM\CurrentControlSet\Control\StorageDevicePolicies";
            //using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            //{
            //    foreach (string skName in rk.GetSubKeyNames())
            //    {
            //        using (RegistryKey sk = rk.OpenSubKey(skName))
            //        {
            //            //Console.WriteLine(sk.GetValue("DisplayName"));
            //            richTextBox1.Text = richTextBox1.Text + sk.GetValue("DisplayName") + "\n";
            //        }
            //    }
            //}

            /*ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
            foreach (ManagementObject mo in mos.Get())
            {
                Console.WriteLine(mo["Name"]);
            }*/
        }
    }
}
