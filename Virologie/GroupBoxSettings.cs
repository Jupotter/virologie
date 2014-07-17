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
    public partial class GroupBoxSettings : UserControl
    {
        public GroupBoxSettings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LaunchCheckBox.Checked = true;
            UpdateCheckBox.Checked = false;
            ShowCheckBox.Checked = true;
            RootkitsCheckBox.Checked = true;
            RecordsCheckBox.Checked = false;
            ExportCheckBox.Checked = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBox.Checked = false;
            ((Form1)Parent).UpdateCheckBox_Click();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form1)Parent).SecurityCheckBox_Click();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (DesignMode) this.Visible = false;
        }
    }
}
