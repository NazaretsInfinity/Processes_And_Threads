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
        Thread tr;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tr = new Thread(PrimaryGeneration);
            tr.Start(); 
        }
        private void FibonacciButton_Click(object sender, EventArgs e)
        {
            tr = new Thread(FibonacciGeneration);
            tr.Start();
        }

        private void PrimaryGeneration()
        {
            int i = (int)NumericStart.Value;
            while(NumericEnd.Value == 0  ?  true : i < NumericEnd.Value)
            {
                int counter = 0;
                for (int p = 2; p <= Math.Sqrt(i); ++p)
                    if (i % p == 0)
                    {
                        counter++;
                        break;
                    }
                if (counter == 0) this.Invoke(new Action(() => OutputTextBox.Text += i.ToString() + " ")); // it didn't give me exception without invoke too. Do I need it ? 
                ++i;
                Thread.Sleep(100);
            }
        }
        private void FibonacciGeneration()
        {
            int a = 0; int b = 1;

            while (a != 3) 
            {
                this.Invoke(new Action(() => OutputTextBox.Text += a.ToString() + " "));
                int n = a + b; a = b; b = n;
                Thread.Sleep(100);
            }
        }

    }
}
