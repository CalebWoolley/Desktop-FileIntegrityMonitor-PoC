using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace FileIntegrityMonitor
{

    public partial class fileIntegrityMonitorForm : Form
    {
 
        //The running list of monitored directories.
        public List<fileIntegrityMonitorDirectory> monitoredDirectories = new List<fileIntegrityMonitorDirectory>();

        //This string is used as a logging system to be viewed for review.
        public static string ongoingLog;

        public fileIntegrityMonitorForm()
        {
            InitializeComponent();
            Thread monitorHighHashes = new Thread(highSensitivityMonitorThread);
            monitorHighHashes.Start();
            Thread monitorMediumHashes = new Thread(mediumSensitivityMonitorThread);
            monitorMediumHashes.Start();
            Thread monitorLowHashes = new Thread(lowSensitivityMonitorThread);
            monitorLowHashes.Start();
            Thread autoSaveThread = new Thread(autoSaveLog);
            autoSaveThread.Start();
        }

        private void fileIntegrityMonitorForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// Calculates the hash of a given file.
        /// </summary>
        /// <param name="filepath">File path of the hash to be calculated.</param>
        /// <returns>The hash of the input file.</returns>
        public string calculateFileMD5(string filepath)
        {
            using (System.IO.FileStream fileStreamReader = new System.IO.FileStream(filepath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                using (System.Security.Cryptography.MD5CryptoServiceProvider md5CryptoProvider = new System.Security.Cryptography.MD5CryptoServiceProvider())
                {
                    byte[] newMD5Hash = md5CryptoProvider.ComputeHash(fileStreamReader);
                    System.Text.StringBuilder sb = new System.Text.StringBuilder(newMD5Hash.Length * 2);
                    for (int i = 0; i <= newMD5Hash.Length - 1; i++)
                        sb.Append(newMD5Hash[i].ToString("X2"));
                    return sb.ToString().ToLower(); 
                }
            }
        }

        private void addNewDirectoryButton_Click(object sender, EventArgs e)
        {
            using (var flbDlg = new FolderBrowserDialog())
            {
                DialogResult result = flbDlg.ShowDialog();

                //Check to ensure the result of folder selection isn't empty, and if so, continue:
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(flbDlg.SelectedPath))
                {
                    fileIntegrityMonitorDirectory newFIMDirectory = new fileIntegrityMonitorDirectory(flbDlg.SelectedPath); 
                    string[] files = Directory.GetFiles(flbDlg.SelectedPath);
                    List<string> directoryFiles = new List<string>();
                    foreach (var file in files)
                    {
                        newFIMDirectory.filesList.Add(file);
                        newFIMDirectory.latestHashList.Add(calculateFileMD5(file));
                    }
                    monitoredDirectories.Add(newFIMDirectory);

                    ListViewItem newDirectoryItem = new ListViewItem(flbDlg.SelectedPath); 
                    newDirectoryItem.SubItems.Add("Low");
                    fileMonitorListView.Items.Add(newDirectoryItem);

                    statusLabel.Text = ("Added a new directory. " + newFIMDirectory.filesList.Count.ToString() + " file hashes calculated.");
                }
            }
        }


        //The following contains code to delete items from the monitored directories list as well as alter their sensitivity levels.
        private void deleteDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            monitoredDirectories.RemoveAt(fileMonitorListView.SelectedIndices[0]);
            fileMonitorListView.SelectedItems[0].Remove();
        }

        private void highToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitoredDirectories[fileMonitorListView.SelectedIndices[0]].sensitivity = "High";
            fileMonitorListView.SelectedItems[0].SubItems[1].Text = "High";
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitoredDirectories[fileMonitorListView.SelectedIndices[0]].sensitivity = "Medium";
            fileMonitorListView.SelectedItems[0].SubItems[1].Text = "Medium";
        }

        private void lowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitoredDirectories[fileMonitorListView.SelectedIndices[0]].sensitivity = "Low";
            fileMonitorListView.SelectedItems[0].SubItems[1].Text = "Low";
        }


        /// <summary>
        /// This is the code that checks the latest hashes of the files in the chosen directories against their stored hash values.
        /// </summary>
        /// <param name="sensitivityLevel">The sensitivity level of the directories to be checked.</param>
        void checkHashFiles(string sensitivityLevel)
        {
                foreach(fileIntegrityMonitorDirectory currentFIMDirectory in monitoredDirectories)
                {
                if(currentFIMDirectory.sensitivity == sensitivityLevel)
                {
                   if (currentFIMDirectory.filesList.Count != 0)
                   {
                       for (int i = 0; i < currentFIMDirectory.filesList.Count; i++)
                        {
                            string latestHash = calculateFileMD5(currentFIMDirectory.filesList[i]);
                            if (currentFIMDirectory.latestHashList[i] != latestHash) {
                                string alertString = "Alert!  The file " + currentFIMDirectory.filesList[i] + " has been changed from its original form.  Please review the alteration!";
                                MessageBox.Show(alertString, "File Integrity Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                statusLabel.Text = alertString;
                                ongoingLog += System.DateTime.Now.ToString() + ": " + alertString + System.Environment.NewLine;
                                currentFIMDirectory.latestHashList[i] = latestHash;
                            }
                        }
                   }
                }
            }
        }

        //High sensitivity: Runs every 1 minute.
        void highSensitivityMonitorThread()
        {
            do
            {
                checkHashFiles("High");
                System.Threading.Thread.Sleep(60000);
            } while (true);
        }

        //Medium sensitivity: Runs every 5 minutes.
        void mediumSensitivityMonitorThread()
        {
            do
            {
                checkHashFiles("Medium");
                System.Threading.Thread.Sleep(300000);
            } while (true);
        }

        //Low sensitivity: Runs every 10 minutes.
        void lowSensitivityMonitorThread()
        {
            do
            {
                checkHashFiles("Low");
                System.Threading.Thread.Sleep(600000);
            } while (true);
        }

        //Low sensitivity: Runs every 10 minutes.
        void autoSaveLog()
        {
            do
            {
               File.WriteAllText("fileIntegrityMonitorLog.txt", ongoingLog);
                System.Threading.Thread.Sleep(30000);
            } while (true);
        }

        fileIntegrityLogForm fileIntegrityLogForm = new fileIntegrityLogForm();
        private void viewLogButton_Click(object sender, EventArgs e)
        {
            fileIntegrityLogForm.Show();
        }
    }

    //Custom class to store data about a monitored directory.
    public class fileIntegrityMonitorDirectory
    {
        public string directory;
        public string sensitivity = "Low";
        public List<string> filesList;
        public List<string> latestHashList;

        public fileIntegrityMonitorDirectory(string newDirectory)
        {
            directory = newDirectory;
            filesList = new List<string>();
            latestHashList = new List<string>();
        }
    }
}



namespace HashFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var result = openFileDialog.ShowDialog();
            if (result == true)
            {
                foreach (var fileName in openFileDialog.FileNames)
                {
                    using (var stream = File.OpenRead(fileName))
                    {
                        var sha256 = new SHA256Managed();
                        var hash = sha256.ComputeHash(stream);
                        Console.WriteLine(BitConverter.ToString(hash).Replace("-", "").ToLower());
                    }
                }
            }
        }
    }
}