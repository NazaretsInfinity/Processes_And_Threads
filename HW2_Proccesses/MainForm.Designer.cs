namespace HW2_Proccesses
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
            this.StartProcessButton = new System.Windows.Forms.Button();
            this.StopChildProccess = new System.Windows.Forms.Button();
            this.TextBoxCount = new System.Windows.Forms.TextBox();
            this.CountButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.labelPATH = new System.Windows.Forms.Label();
            this.labelWORD = new System.Windows.Forms.Label();
            this.WordCountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartProcessButton
            // 
            this.StartProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartProcessButton.Location = new System.Drawing.Point(12, 12);
            this.StartProcessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartProcessButton.Name = "StartProcessButton";
            this.StartProcessButton.Size = new System.Drawing.Size(235, 69);
            this.StartProcessButton.TabIndex = 0;
            this.StartProcessButton.Text = "Start proccess";
            this.StartProcessButton.UseVisualStyleBackColor = true;
            this.StartProcessButton.Click += new System.EventHandler(this.StartProcessButton_Click);
            // 
            // StopChildProccess
            // 
            this.StopChildProccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopChildProccess.Location = new System.Drawing.Point(12, 98);
            this.StopChildProccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopChildProccess.Name = "StopChildProccess";
            this.StopChildProccess.Size = new System.Drawing.Size(235, 74);
            this.StopChildProccess.TabIndex = 1;
            this.StopChildProccess.Text = "Stop process";
            this.StopChildProccess.UseVisualStyleBackColor = true;
            this.StopChildProccess.Click += new System.EventHandler(this.StopChildProccess_Click);
            // 
            // TextBoxCount
            // 
            this.TextBoxCount.Location = new System.Drawing.Point(12, 234);
            this.TextBoxCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxCount.Name = "TextBoxCount";
            this.TextBoxCount.Size = new System.Drawing.Size(235, 22);
            this.TextBoxCount.TabIndex = 2;
            this.TextBoxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CountButton
            // 
            this.CountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountButton.Location = new System.Drawing.Point(12, 265);
            this.CountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(237, 44);
            this.CountButton.TabIndex = 3;
            this.CountButton.Text = "count";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(71, 360);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(176, 22);
            this.PathTextBox.TabIndex = 4;
            this.PathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WordTextBox
            // 
            this.WordTextBox.Location = new System.Drawing.Point(71, 388);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.Size = new System.Drawing.Size(176, 22);
            this.WordTextBox.TabIndex = 5;
            this.WordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPATH
            // 
            this.labelPATH.AutoSize = true;
            this.labelPATH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPATH.Location = new System.Drawing.Point(12, 362);
            this.labelPATH.Name = "labelPATH";
            this.labelPATH.Size = new System.Drawing.Size(53, 20);
            this.labelPATH.TabIndex = 6;
            this.labelPATH.Text = "Path:";
            // 
            // labelWORD
            // 
            this.labelWORD.AutoSize = true;
            this.labelWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWORD.Location = new System.Drawing.Point(12, 390);
            this.labelWORD.Name = "labelWORD";
            this.labelWORD.Size = new System.Drawing.Size(59, 20);
            this.labelWORD.TabIndex = 7;
            this.labelWORD.Text = "Word:";
            // 
            // WordCountButton
            // 
            this.WordCountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordCountButton.Location = new System.Drawing.Point(15, 414);
            this.WordCountButton.Margin = new System.Windows.Forms.Padding(4);
            this.WordCountButton.Name = "WordCountButton";
            this.WordCountButton.Size = new System.Drawing.Size(237, 44);
            this.WordCountButton.TabIndex = 8;
            this.WordCountButton.Text = "count words";
            this.WordCountButton.UseVisualStyleBackColor = true;
            this.WordCountButton.Click += new System.EventHandler(this.WordCountButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 474);
            this.Controls.Add(this.WordCountButton);
            this.Controls.Add(this.labelWORD);
            this.Controls.Add(this.labelPATH);
            this.Controls.Add(this.WordTextBox);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.TextBoxCount);
            this.Controls.Add(this.StopChildProccess);
            this.Controls.Add(this.StartProcessButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartProcessButton;
        private System.Windows.Forms.Button StopChildProccess;
        private System.Windows.Forms.TextBox TextBoxCount;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.Label labelPATH;
        private System.Windows.Forms.Label labelWORD;
        private System.Windows.Forms.Button WordCountButton;
    }
}

