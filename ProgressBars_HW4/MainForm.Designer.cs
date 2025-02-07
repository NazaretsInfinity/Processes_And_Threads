namespace ProgressBars_HW4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumericBars = new System.Windows.Forms.NumericUpDown();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FibonacciTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.BorderLabel = new System.Windows.Forms.Label();
            this.CountButton = new System.Windows.Forms.Button();
            this.StartSecond = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBars)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericBars
            // 
            this.NumericBars.Location = new System.Drawing.Point(266, 17);
            this.NumericBars.Name = "NumericBars";
            this.NumericBars.Size = new System.Drawing.Size(61, 22);
            this.NumericBars.TabIndex = 0;
            this.NumericBars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStart.Location = new System.Drawing.Point(333, 12);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(98, 32);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Epic Horse Racing";
            // 
            // FibonacciTextBox
            // 
            this.FibonacciTextBox.Enabled = false;
            this.FibonacciTextBox.Location = new System.Drawing.Point(12, 309);
            this.FibonacciTextBox.Name = "FibonacciTextBox";
            this.FibonacciTextBox.Size = new System.Drawing.Size(421, 22);
            this.FibonacciTextBox.TabIndex = 3;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(266, 281);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.NumberTextBox.TabIndex = 4;
            // 
            // BorderLabel
            // 
            this.BorderLabel.AutoSize = true;
            this.BorderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BorderLabel.Location = new System.Drawing.Point(372, 284);
            this.BorderLabel.Name = "BorderLabel";
            this.BorderLabel.Size = new System.Drawing.Size(54, 16);
            this.BorderLabel.TabIndex = 5;
            this.BorderLabel.Text = "Border";
            // 
            // CountButton
            // 
            this.CountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountButton.Location = new System.Drawing.Point(19, 281);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(75, 23);
            this.CountButton.TabIndex = 6;
            this.CountButton.Text = "count";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // StartSecond
            // 
            this.StartSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartSecond.Location = new System.Drawing.Point(333, 50);
            this.StartSecond.Name = "StartSecond";
            this.StartSecond.Size = new System.Drawing.Size(98, 55);
            this.StartSecond.TabIndex = 7;
            this.StartSecond.Text = "2nd Task";
            this.StartSecond.UseVisualStyleBackColor = true;
            this.StartSecond.Click += new System.EventHandler(this.StartSecond_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 343);
            this.Controls.Add(this.StartSecond);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.BorderLabel);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.FibonacciTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.NumericBars);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumericBars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericBars;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FibonacciTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label BorderLabel;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.Button StartSecond;
    }
}

