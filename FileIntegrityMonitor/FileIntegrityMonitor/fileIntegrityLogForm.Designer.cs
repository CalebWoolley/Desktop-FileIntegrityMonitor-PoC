namespace FileIntegrityMonitor
{
    partial class fileIntegrityLogForm
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
            this.fileIntegrityLogTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileIntegrityLogTextBox
            // 
            this.fileIntegrityLogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileIntegrityLogTextBox.Location = new System.Drawing.Point(0, 0);
            this.fileIntegrityLogTextBox.Multiline = true;
            this.fileIntegrityLogTextBox.Name = "fileIntegrityLogTextBox";
            this.fileIntegrityLogTextBox.ReadOnly = true;
            this.fileIntegrityLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fileIntegrityLogTextBox.Size = new System.Drawing.Size(1207, 316);
            this.fileIntegrityLogTextBox.TabIndex = 0;
            // 
            // fileIntegrityLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 316);
            this.Controls.Add(this.fileIntegrityLogTextBox);
            this.Name = "fileIntegrityLogForm";
            this.Text = "File Integrity Log Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fileIntegrityLogForm_FormClosing);
            this.Load += new System.EventHandler(this.fileIntegrityLogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileIntegrityLogTextBox;
    }
}