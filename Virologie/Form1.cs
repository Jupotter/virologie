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
    public partial class Form1 : Form
    {
        private List<Component> HomeCollection;
        private List<Component> ScanCollection;
        private List<Component> SecurityCollection;
        private List<Component> UpdateCollection;
        private List<Component> SettingsCollection;

        public Form1()
        {
            InitializeComponent();
            HomeCheckBox.CheckState = CheckState.Checked;

            HomeCollection = new List<Component>();
            ScanCollection = new List<Component>();
            SecurityCollection = new List<Component>();
            UpdateCollection = new List<Component>();
            SettingsCollection = new List<Component>();

            HomeCollection.Add(WarningTextBox);
            HomeCollection.Add(DangerPictureBox);
            HomeCollection.Add(SystemLabel);
            HomeCollection.Add(LastScanLabel);
            HomeCollection.Add(ScanRedirectLabel);

            DisableControlCollection(ScanCollection);
            DisableControlCollection(SecurityCollection);
            DisableControlCollection(UpdateCollection);
            DisableControlCollection(SettingsCollection);
            EnableControlCollection(HomeCollection);
        }

        private void EnableControlCollection(List<Component> list)
        {
            foreach (Control c in list) c.Visible = true;
        }

        private void DisableControlCollection(List<Component> list)
        {
            foreach (Control c in list) c.Visible = false;
        }

        private void HomeCheckBox_Click(object sender, EventArgs e)
        {
            HomeCheckBox.CheckState = CheckState.Checked;
            ScanCheckBox.CheckState = CheckState.Unchecked;
            SecurityCheckBox.CheckState = CheckState.Unchecked;
            UpdateCheckBox.CheckState = CheckState.Unchecked;
            SettingsCheckBox.CheckState = CheckState.Unchecked;

            EnableControlCollection(HomeCollection);
            DisableControlCollection(ScanCollection);
            DisableControlCollection(SecurityCollection);
            DisableControlCollection(UpdateCollection);
            DisableControlCollection(SettingsCollection);
        }

        private void ScanCheckBox_Click(object sender, EventArgs e)
        {
            HomeCheckBox.CheckState = CheckState.Unchecked;
            ScanCheckBox.CheckState = CheckState.Checked;
            SecurityCheckBox.CheckState = CheckState.Unchecked;
            UpdateCheckBox.CheckState = CheckState.Unchecked;
            SettingsCheckBox.CheckState = CheckState.Unchecked;

            DisableControlCollection(HomeCollection);
            EnableControlCollection(ScanCollection);
            DisableControlCollection(SecurityCollection);
            DisableControlCollection(UpdateCollection);
            DisableControlCollection(SettingsCollection);
        }

        private void SecurityCheckBox_Click(object sender, EventArgs e)
        {
            HomeCheckBox.CheckState = CheckState.Unchecked;
            ScanCheckBox.CheckState = CheckState.Unchecked;
            SecurityCheckBox.CheckState = CheckState.Checked;
            UpdateCheckBox.CheckState = CheckState.Unchecked;
            SettingsCheckBox.CheckState = CheckState.Unchecked;

            DisableControlCollection(HomeCollection);
            DisableControlCollection(ScanCollection);
            EnableControlCollection(SecurityCollection);
            DisableControlCollection(UpdateCollection);
            DisableControlCollection(SettingsCollection);
        }

        private void UpdateCheckBox_Click(object sender, EventArgs e)
        {
            HomeCheckBox.CheckState = CheckState.Unchecked;
            ScanCheckBox.CheckState = CheckState.Unchecked;
            SecurityCheckBox.CheckState = CheckState.Unchecked;
            UpdateCheckBox.CheckState = CheckState.Checked;
            SettingsCheckBox.CheckState = CheckState.Unchecked;

            DisableControlCollection(HomeCollection);
            DisableControlCollection(ScanCollection);
            DisableControlCollection(SecurityCollection);
            EnableControlCollection(UpdateCollection);
            DisableControlCollection(SettingsCollection);
        }

        private void SettingsCheckBox_Click(object sender, EventArgs e)
        {
            HomeCheckBox.CheckState = CheckState.Unchecked;
            ScanCheckBox.CheckState = CheckState.Unchecked;
            SecurityCheckBox.CheckState = CheckState.Unchecked;
            UpdateCheckBox.CheckState = CheckState.Unchecked;
            SettingsCheckBox.CheckState = CheckState.Checked;

            DisableControlCollection(HomeCollection);
            DisableControlCollection(ScanCollection);
            DisableControlCollection(SecurityCollection);
            DisableControlCollection(UpdateCollection);
            EnableControlCollection(SettingsCollection);
        }
    }
}
