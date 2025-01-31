using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessListTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBoxTime.Text = "100";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

     

        private void RefreshProcessList()
        {
            listBox1.Items.Clear();
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                listBox1.Items.Add($"{process.ProcessName} (ID: {process.Id})");
            }
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxTime.Text, out int interval) && interval > 0)
            {
                timer1.Interval = interval * 1000;
                timer1.Start();
                buttonstart.Enabled = false;
                TextBoxTime.Enabled = false;
            }
            else
            {
                MessageBox.Show("rewrite.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshProcessList();
        }
    }
}
