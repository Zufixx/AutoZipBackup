using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace AutoZipBackup
{
    public partial class Form1 : Form
    {
        private string fromDirectory = @"";
        private string toDirectory = @"";

        private bool zipped = true;

        public Form1()
        {
            InitializeComponent();
            copyButton.Enabled = false;
            fromBox.Text = fromDirectory;
            toBox.Text = toDirectory;
            output.Text = "Select folders to copy to and from. (Optional) Add the branch name\n";
            branchBox.Text = "master";

            if (fromDirectory != null && toDirectory != null)
                copyButton.Enabled = true;
            else
                copyButton.Enabled = false;
        }

        private void fromButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                fromDirectory = folderBrowserDialog.SelectedPath;
                fromBox.Text = fromDirectory;
            }
            else
                return;

            if (fromDirectory != null && toDirectory != null)
                copyButton.Enabled = true;
            else
                copyButton.Enabled = false;

        }

        private void toButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                toDirectory = folderBrowserDialog.SelectedPath;
                toBox.Text = toDirectory;
            }
            else
                return;

            if (fromDirectory != null && toDirectory != null)
                copyButton.Enabled = true;
            else
                copyButton.Enabled = false;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (fromDirectory == null && toDirectory == null)
                return;

            copyButton.Enabled = false;

            string zipPath = @"C:\temp\tempBackup.zip";
            toDirectory = toDirectory + "/" + DateTime.Today.ToString("d");
            if (zipped)
            {
                if(branchBox.Text != "")
                    zipPath = toDirectory + " " + branchBox.Text + ".zip";
                else
                    zipPath = toDirectory + ".zip";

                output.Text += DateTime.Now.ToString("HH:mm:ss") + ": Zipping Files. Please wait.\n";
                if (File.Exists(zipPath))
                    File.Delete(zipPath);
                ZipFile.CreateFromDirectory(fromDirectory, zipPath);
                output.Text += DateTime.Now.ToString("HH:mm:ss") + ": Done!\n\n";
            }
            else
            {
                if (branchBox.Text != "")
                    toDirectory += " " + branchBox.Text;

                if (File.Exists(zipPath))
                    File.Delete(zipPath);

                output.Text += DateTime.Now.ToString("HH:mm:ss") + ": Zipping Files. Please wait.\n";
                ZipFile.CreateFromDirectory(fromDirectory, zipPath);
                output.Text += DateTime.Now.ToString("HH:mm:ss") + ": Extracting files. Please wait.\n";

                if (Directory.Exists(toDirectory))
                    Directory.Delete(toDirectory);

                ZipFile.ExtractToDirectory(zipPath, toDirectory);
                output.Text += DateTime.Now.ToString("HH:mm:ss") + ": Deleting temporary zip folder.\n";
                File.Delete(zipPath);
                output.Text += DateTime.Now.ToString("HH:mm:ss") + ": Done!\n\n";
            }

            copyButton.Enabled = true;
        }

        private void zippedCheck_CheckedChanged(object sender, EventArgs e)
        {
            zipped = zippedCheck.Checked;
        }
    }
}
