using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                return;
            }

            _worker = new EncryptWorker(name);
            _worker.ProgressChanged += _worker_ProgressChanged;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;

            label3.Location = progressBar1.Location;
            label3.Visible = true;
            progressBar1.Location = GuidBox.Location;
            progressBar1.Visible = true;
            GuidBox.Visible = false;
            decryptButton.Enabled = false;
            button1.Enabled = false;

            _worker.RunWorkerAsync();
        }

        void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
            label3.Text = "Cleanup complete";
            CryptoKeyManager.CleanGuid();
        }

        void _worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

            label3.Text = string.Format("Decrypting {0}", _worker.CurrentFile);
        }
    }
}
