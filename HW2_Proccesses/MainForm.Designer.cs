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
            this.StopChildProccess.Name = "StopChildProccess";
            this.StopChildProccess.Size = new System.Drawing.Size(235, 74);
            this.StopChildProccess.TabIndex = 1;
            this.StopChildProccess.Text = "Stop process";
            this.StopChildProccess.UseVisualStyleBackColor = true;
            this.StopChildProccess.Click += new System.EventHandler(this.StopChildProccess_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 194);
            this.Controls.Add(this.StopChildProccess);
            this.Controls.Add(this.StartProcessButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartProcessButton;
        private System.Windows.Forms.Button StopChildProccess;
    }
}

