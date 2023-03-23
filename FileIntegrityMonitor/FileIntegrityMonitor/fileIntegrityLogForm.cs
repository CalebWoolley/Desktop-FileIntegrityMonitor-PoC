using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIntegrityMonitor
{
    public partial class fileIntegrityLogForm : Form
    {
        public fileIntegrityLogForm()
        {
            InitializeComponent();
        }

        private void fileIntegrityLogForm_Load(object sender, EventArgs e)
        {
            fileIntegrityLogTextBox.Text = fileIntegrityMonitorForm.ongoingLog;
        }

        private void fileIntegrityLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
