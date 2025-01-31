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
            this.SuspendLayout();
            // 
            // StartProcessButton
            // 
            this.StartProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartProcessButton.Location = new System.Drawing.Point(9, 10);
            this.StartProcessButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartProcessButton.Name = "StartProcessButton";
            this.StartProcessButton.Size = new System.Drawing.Size(176, 56);
            this.StartProcessButton.TabIndex = 0;
            this.StartProcessButton.Text = "Start proccess";
            this.StartProcessButton.UseVisualStyleBackColor = true;
            this.StartProcessButton.Click += new System.EventHandler(this.StartProcessButton_Click);
            // 
            // StopChildProccess
            // 
            this.StopChildProccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopChildProccess.Location = new System.Drawing.Point(9, 80);
            this.StopChildProccess.Margin = new System.Windows.Forms.Padding(2);
            this.StopChildProccess.Name = "StopChildProccess";
            this.StopChildProccess.Size = new System.Drawing.Size(176, 60);
            this.StopChildProccess.TabIndex = 1;
            this.StopChildProccess.Text = "Stop process";
            this.StopChildProccess.UseVisualStyleBackColor = true;
            this.StopChildProccess.Click += new System.EventHandler(this.StopChildProccess_Click);
            // 
            // TextBoxCount
            // 
            this.TextBoxCount.Location = new System.Drawing.Point(9, 190);
            this.TextBoxCount.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCount.Name = "TextBoxCount";
            this.TextBoxCount.Size = new System.Drawing.Size(177, 20);
            this.TextBoxCount.TabIndex = 2;
            this.TextBoxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CountButton
            // 
            this.CountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountButton.Location = new System.Drawing.Point(9, 215);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(178, 36);
            this.CountButton.TabIndex = 3;
            this.CountButton.Text = "count";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 272);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.TextBoxCount);
            this.Controls.Add(this.StopChildProccess);
            this.Controls.Add(this.StartProcessButton);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

