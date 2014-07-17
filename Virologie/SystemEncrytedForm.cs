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
        public SystemEncrytedForm()
        {
            InitializeComponent();

            GuidBox.Text = CryptoKeyManager.guid.ToString();
        }
    }
}
