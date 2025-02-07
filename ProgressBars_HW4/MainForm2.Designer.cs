namespace ProgressBars_HW4
{
    partial class MainForm2
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
            this.labelPath = new System.Windows.Forms.Label();
            this.labelWord = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPath.Location = new System.Drawing.Point(23, 28);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(122, 29);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "File path:";
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWord.Location = new System.Drawing.Point(23, 70);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(82, 29);
            this.labelWord.TabIndex = 1;
            this.labelWord.Text = "Word:";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(151, 35);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(309, 22);
            this.PathTextBox.TabIndex = 2;
            // 
            // WordTextBox
            // 
            this.WordTextBox.Location = new System.Drawing.Point(151, 77);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.Size = new System.Drawing.Size(309, 22);
            this.WordTextBox.TabIndex = 3;
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 119);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(592, 27);
            this.StatusStrip.TabIndex = 4;
            this.StatusStrip.Text = "Amount of words:";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(478, 35);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(80, 64);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StripStatusLabel
            // 
            this.StripStatusLabel.Name = "StripStatusLabel";
            this.StripStatusLabel.Size = new System.Drawing.Size(112, 21);
            this.StripStatusLabel.Text = "No occurences";
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 146);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.WordTextBox);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.labelPath);
            this.Name = "MainForm2";
            this.Text = "MainForm2";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabel;
    }
}