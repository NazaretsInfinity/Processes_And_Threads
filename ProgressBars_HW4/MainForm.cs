using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBars_HW4
{
    public partial class MainForm : Form
    {
        List<ProgressBar> bars = new List<ProgressBar>();
        bool activity = false;
        Task task;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            activity = !activity;
            if (!activity)
            {
                await task;
                for (int i = 0; i < bars.Count; ++i)
                        this.Controls.RemoveByKey("ProgressBar" + i);
                    bars.Clear();
            }
            else
            {
                for (int i = 0; i < NumericBars.Value; ++i)
                {
                    ProgressBar bar = new ProgressBar();
                    bar.Size = new Size(100, 20); ;
                    bar.Location = new Point(20, 40 * (i + 1));
                    bar.Name = $"ProgressBar{i}";
                    this.Controls.Add(bar);
                    bars.Add(bar);
                }
                //ThreadPool.QueueUserWorkItem(new WaitCallback(FillBars));
                task = Task.Run(FillBars);
            }
         
            
        }

        //METHODS
        private void FillBars()
        {
          while (activity)
                    foreach (ProgressBar bar in bars)
                        this.Invoke(new Action(() => bar.Value = new Random().Next(50, 70)));
        }
    }
}
