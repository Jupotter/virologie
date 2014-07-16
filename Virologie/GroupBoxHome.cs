using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace Virologie
{
    [HelpKeyword(typeof(UserControl))]
    [ToolboxItem("System.Windows.Forms.Design.AutoSizeToolboxItem,System.Design")]
    public partial class GroupBoxHome : UserControl
    {
        public GroupBoxHome()
        {
            InitializeComponent();
            VersionDateLabel.Text = "v"+ DateTime.Now.ToString("yy.MM.dd.HH");
        }

        private void ScanRedirectLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((Form1)Parent).ScanCheckBox_Click();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (DesignMode) this.Visible = false;
        }
    }
}
