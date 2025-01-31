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
using System.Runtime.InteropServices;
using System.IO;

namespace HW2_Proccesses
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hwnd, string txt, string caption, uint type);

        Process proc = new Process();
        public MainForm()
        {
            InitializeComponent();
            proc.StartInfo = new ProcessStartInfo("HW2_ChildProccess");
            StopChildProccess.Enabled = false;
        }

      
        private void StartProcessButton_Click(object sender, EventArgs e) //1 
        {
           proc.StartInfo.UseShellExecute = false;
           StartProcessButton.Enabled = false;
            proc.Start();
            if(MessageBox(IntPtr.Zero, "ChildProccess started. Wish to close it yourself?", "decision.", 3)== 7)
            {
                proc.WaitForExit();
                MessageBox(IntPtr.Zero, $"Proccess has exited with code {proc.ExitCode}", "Completed", 1);
                StartProcessButton.Enabled = true;
            }
            else StopChildProccess.Enabled=true;
        }

        private void StopChildProccess_Click(object sender, EventArgs e) //2 
        {
            if (!proc.HasExited)
            {
                proc.Kill();
                MessageBox(IntPtr.Zero, "Proccess has been MURDERED by user", "Completed", 1);
            }
            else 
            {
                MessageBox(IntPtr.Zero, "Seems it's already closed", "Completed", 1);
            }
                StopChildProccess.Enabled = false;
                StartProcessButton.Enabled = true;
        }

        private void CountButton_Click(object sender, EventArgs e) //3
        {
           proc.StartInfo.Arguments = TextBoxCount.Text;
            //proc.Start();
            StartProcessButton_Click(sender,e); //here we got all buttons ruled already.
           
        }
    }// END OF FORM
}
