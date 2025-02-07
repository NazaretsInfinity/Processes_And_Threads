using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBars_HW4
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            string filename = PathTextBox.Text;
            FileStream SourceStream = File.Open(PathTextBox.Text, FileMode.Open);
            byte[] result = new byte[SourceStream.Length];

            await SourceStream.ReadAsync(result, 0, (int)SourceStream.Length);

            string line = System.Text.Encoding.ASCII.GetString(result);
            string[] chto = { $"{WordTextBox.Text}" }; // just copied that from my past homework nevermind 
            StripStatusLabel.Text = $"Amount of '{WordTextBox.Text}' word  in file is { line.Split(chto, 0).Length - 1}";

            SourceStream.Close();
            SourceStream.Dispose();
    }

    }
}
