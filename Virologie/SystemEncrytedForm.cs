using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Virologie
{
    public partial class SystemEncrytedForm : Form
    {
        private EncryptWorker _worker;

        public SystemEncrytedForm()
        {
            InitializeComponent();

            GuidBox.Text = CryptoKeyManager.guid.ToString();
            TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = openFileDialog1.FileName;

            try
            {
                CryptoKeyManager.CreateFromFile(name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The file you provided is not a correct key. Please make sure you select the license key given when you registered",
                    "Error during scan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _worker = new EncryptWorker(name);
            _worker.ProgressChanged += _worker_ProgressChanged;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;

            panel1.Location = GuidBox.Location;
            panel1.Visible = true;
            GuidBox.Visible = false;
            decryptButton.Enabled = false;
            button1.Enabled = false;

            _worker.RunWorkerAsync();
        }

        void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Exception error = e.Error;
                if (error.GetType() == typeof (FileNotFoundException))
                    MessageBox.Show(
                        "The file you provided is not a correct key. Please make sure you select the license key given when you registered",
                        "Error during scan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Unknown error during the scan. Please contact support.",
                        "Error during scan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            label3.Text = "Cleanup complete";
            CryptoKeyManager.CleanGuid();
            ControlBox = true;
        }

        void _worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            label3.Text = string.Format("Decrypting {0}", _worker.CurrentFile);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TopMost = false;
            CryptoKeyManager.OpenWebsite();
        }
    }
}
