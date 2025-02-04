namespace HW3_Threads
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
            this.button1 = new System.Windows.Forms.Button();
            this.NumericStart = new System.Windows.Forms.NumericUpDown();
            this.StartLabel = new System.Windows.Forms.Label();
            this.EndLabel = new System.Windows.Forms.Label();
            this.NumericEnd = new System.Windows.Forms.NumericUpDown();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.FibonacciButton = new System.Windows.Forms.Button();
            this.PausePrime = new System.Windows.Forms.Button();
            this.PauseFibo = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start primary numbers generation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumericStart
            // 
            this.NumericStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NumericStart.Location = new System.Drawing.Point(100, 21);
            this.NumericStart.Name = "NumericStart";
            this.NumericStart.Size = new System.Drawing.Size(85, 22);
            this.NumericStart.TabIndex = 1;
            this.NumericStart.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartLabel.Location = new System.Drawing.Point(9, 21);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(85, 20);
            this.StartLabel.TabIndex = 2;
            this.StartLabel.Text = "Start with:";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndLabel.Location = new System.Drawing.Point(237, 20);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(78, 20);
            this.EndLabel.TabIndex = 3;
            this.EndLabel.Text = "End with:";
            // 
            // NumericEnd
            // 
            this.NumericEnd.Location = new System.Drawing.Point(321, 21);
            this.NumericEnd.Name = "NumericEnd";
            this.NumericEnd.Size = new System.Drawing.Size(85, 22);
            this.NumericEnd.TabIndex = 4;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.OutputTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.OutputTextBox.Location = new System.Drawing.Point(13, 158);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(394, 22);
            this.OutputTextBox.TabIndex = 5;
            // 
            // FibonacciButton
            // 
            this.FibonacciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FibonacciButton.Location = new System.Drawing.Point(13, 91);
            this.FibonacciButton.Name = "FibonacciButton";
            this.FibonacciButton.Size = new System.Drawing.Size(393, 36);
            this.FibonacciButton.TabIndex = 6;
            this.FibonacciButton.Text = "Start Fibonacci numbers generation";
            this.FibonacciButton.UseVisualStyleBackColor = true;
            this.FibonacciButton.Click += new System.EventHandler(this.FibonacciButton_Click);
            // 
            // PausePrime
            // 
            this.PausePrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PausePrime.Location = new System.Drawing.Point(13, 202);
            this.PausePrime.Name = "PausePrime";
            this.PausePrime.Size = new System.Drawing.Size(96, 34);
            this.PausePrime.TabIndex = 7;
            this.PausePrime.Text = "Pause";
            this.PausePrime.UseVisualStyleBackColor = true;
            // 
            // PauseFibo
            // 
            this.PauseFibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseFibo.Location = new System.Drawing.Point(12, 242);
            this.PauseFibo.Name = "PauseFibo";
            this.PauseFibo.Size = new System.Drawing.Size(96, 34);
            this.PauseFibo.TabIndex = 8;
            this.PauseFibo.Text = "Pause";
            this.PauseFibo.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(310, 202);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(96, 34);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 310);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.PauseFibo);
            this.Controls.Add(this.PausePrime);
            this.Controls.Add(this.FibonacciButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.NumericEnd);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.NumericStart);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown NumericStart;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.NumericUpDown NumericEnd;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button FibonacciButton;
        private System.Windows.Forms.Button PausePrime;
        private System.Windows.Forms.Button PauseFibo;
        private System.Windows.Forms.Button buttonClear;
    }
}

