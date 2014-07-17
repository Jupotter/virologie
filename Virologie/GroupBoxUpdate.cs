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
    public partial class GroupBoxUpdate : UserControl
    {
        public GroupBoxUpdate()
        {
            InitializeComponent();
        }

        private void OffCheckBox_Click(object sender, EventArgs e)
        {
            OffCheckBox.Checked = true;
        }

        private void OnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckBox.Checked = false;
            ((Form1)Parent).SecurityCheckBox_Click();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (DesignMode) this.Visible = false;
        }
    }
}
