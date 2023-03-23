namespace FileIntegrityMonitor
{
    partial class fileIntegrityMonitorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileIntegrityMonitorForm));
            this.fileMonitorListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileMonitorMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sensitivityLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMarkerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.optionsDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewLogButton = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDirectoryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMonitorMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileMonitorListView
            // 
            this.fileMonitorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.fileMonitorListView.ContextMenuStrip = this.fileMonitorMenu;
            this.fileMonitorListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileMonitorListView.FullRowSelect = true;
            this.fileMonitorListView.GridLines = true;
            this.fileMonitorListView.HideSelection = false;
            this.fileMonitorListView.Location = new System.Drawing.Point(0, 0);
            this.fileMonitorListView.MultiSelect = false;
            this.fileMonitorListView.Name = "fileMonitorListView";
            this.fileMonitorListView.Size = new System.Drawing.Size(1167, 426);
            this.fileMonitorListView.TabIndex = 0;
            this.fileMonitorListView.UseCompatibleStateImageBehavior = false;
            this.fileMonitorListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Directory";
            this.columnHeader2.Width = 590;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sensitivity Level";
            this.columnHeader3.Width = 111;
            // 
            // fileMonitorMenu
            // 
            this.fileMonitorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensitivityLevelToolStripMenuItem,
            this.deleteDirectoryToolStripMenuItem});
            this.fileMonitorMenu.Name = "fileMonitorMenu";
            this.fileMonitorMenu.Size = new System.Drawing.Size(159, 48);
            // 
            // sensitivityLevelToolStripMenuItem
            // 
            this.sensitivityLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.lowToolStripMenuItem});
            this.sensitivityLevelToolStripMenuItem.Name = "sensitivityLevelToolStripMenuItem";
            this.sensitivityLevelToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sensitivityLevelToolStripMenuItem.Text = "Sensitivity Level";
            // 
            // highToolStripMenuItem
            // 
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            this.highToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.highToolStripMenuItem.Text = "High";
            this.highToolStripMenuItem.Click += new System.EventHandler(this.highToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // lowToolStripMenuItem
            // 
            this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
            this.lowToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.lowToolStripMenuItem.Text = "Low";
            this.lowToolStripMenuItem.Click += new System.EventHandler(this.lowToolStripMenuItem_Click);
            // 
            // deleteDirectoryToolStripMenuItem
            // 
            this.deleteDirectoryToolStripMenuItem.Name = "deleteDirectoryToolStripMenuItem";
            this.deleteDirectoryToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteDirectoryToolStripMenuItem.Text = "Delete Directory";
            this.deleteDirectoryToolStripMenuItem.Click += new System.EventHandler(this.deleteDirectoryToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMarkerLabel,
            this.statusLabel,
            this.optionsDropDown});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1167, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusMarkerLabel
            // 
            this.statusMarkerLabel.Name = "statusMarkerLabel";
            this.statusMarkerLabel.Size = new System.Drawing.Size(42, 17);
            this.statusMarkerLabel.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(29, 17);
            this.statusLabel.Text = "Idle.";
            // 
            // optionsDropDown
            // 
            this.optionsDropDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.optionsDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.optionsDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLogButton,
            this.addNewDirectoryButton});
            this.optionsDropDown.Image = ((System.Drawing.Image)(resources.GetObject("optionsDropDown.Image")));
            this.optionsDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optionsDropDown.Name = "optionsDropDown";
            this.optionsDropDown.Size = new System.Drawing.Size(62, 20);
            this.optionsDropDown.Text = "Options";
            // 
            // viewLogButton
            // 
            this.viewLogButton.Name = "viewLogButton";
            this.viewLogButton.Size = new System.Drawing.Size(180, 22);
            this.viewLogButton.Text = "View Log";
            this.viewLogButton.Click += new System.EventHandler(this.viewLogButton_Click);
            // 
            // addNewDirectoryButton
            // 
            this.addNewDirectoryButton.Name = "addNewDirectoryButton";
            this.addNewDirectoryButton.Size = new System.Drawing.Size(180, 22);
            this.addNewDirectoryButton.Text = "Add New Directory";
            this.addNewDirectoryButton.Click += new System.EventHandler(this.addNewDirectoryButton_Click);
            // 
            // fileIntegrityMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 426);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.fileMonitorListView);
            this.Name = "fileIntegrityMonitorForm";
            this.Text = "File Integrity Monitor (Proof of Concept)";
            this.Load += new System.EventHandler(this.fileIntegrityMonitorForm_Load);
            this.fileMonitorMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView fileMonitorListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusMarkerLabel;
        private System.Windows.Forms.ToolStripDropDownButton optionsDropDown;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem viewLogButton;
        private System.Windows.Forms.ToolStripMenuItem addNewDirectoryButton;
        private System.Windows.Forms.ContextMenuStrip fileMonitorMenu;
        private System.Windows.Forms.ToolStripMenuItem sensitivityLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDirectoryToolStripMenuItem;
    }
}

