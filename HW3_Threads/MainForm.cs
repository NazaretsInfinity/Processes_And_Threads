using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HW3_Threads
{
    public partial class MainForm : Form
    {
        bool activity = false;
        Thread tr;
        Thread tr2;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //1 primary button
        {
            if (activity) // 3 start and stop button merged, 
            {
                tr.Abort();
                button1.Text = "Start primary numbers generation";
                activity = false;
            }
            else
            {
                tr = new Thread(PrimaryGeneration); 
                tr.Start();
                button1.Text = "Stop";
                activity = true;
            }
            
        }
        private void FibonacciButton_Click(object sender, EventArgs e) //2 
        {
                tr2 = new Thread(FibonacciGeneration);
                tr2.Start();       
        }

        private void PrimaryGeneration()
        {
            int i = (int)NumericStart.Value;
            while(NumericEnd.Value == 0  ?  true : i < NumericEnd.Value)
            {
                bool IsPrime = true;
                for (int p = 2; p <= Math.Sqrt(i); ++p)
                    if (i % p == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                if (IsPrime) this.Invoke(new Action(() => OutputTextBox.Text += i.ToString() + " ")); // it didn't give me exception without invoke too. Idk do I need it? 
                ++i;
                Thread.Sleep(100);
            }
            button1.Text = "Start primary numbers generation"; // for this case only, cause I apply for one button only (IN CASE thread die before I push stop)
            activity = false;
        }
        private void FibonacciGeneration()
        {
            int a = 0; int b = 1;

            while (a <= NumericEnd.Value) 
            {
                this.Invoke(new Action(() => OutputTextBox.Text += a.ToString() + " "));
                int n = a + b; a = b; b = n;
                Thread.Sleep(100);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)  
        {
                this.Invoke(new Action(() => OutputTextBox.Clear()));   
        }

        private void PausePrime_Click(object sender, EventArgs e)  //4 pause
        {
            if(activity)
            {
                tr.Suspend();
                this.Invoke(new Action(() => PausePrime.Text = "Resume"));
                button1.Enabled = false;
                
            }
            if(tr.ThreadState == ThreadState.Suspended)
            {
                tr.Resume();
                this.Invoke(new Action(() => PausePrime.Text = "Pause"));
                button1.Enabled = true;
            }
        }
    }
}
