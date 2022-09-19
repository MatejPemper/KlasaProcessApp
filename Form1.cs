using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KlasaProcessApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNet_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe");
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");

        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void buttonStartInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("chrome.exe");

            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            startInfo.Arguments = "www.sser.hr";

            Process.Start(startInfo);
        }
    }
}
