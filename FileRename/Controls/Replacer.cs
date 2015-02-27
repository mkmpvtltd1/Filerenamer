using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRename.Controls
{
    public partial class Replacer : UserControl
    {
        public string OldString { get; set; }
        public string NewString { get; set; }
        public Replacer()
        {
            InitializeComponent();
        }

        private void txtOld_TextChanged(object sender, EventArgs e)
        {
            OldString = txtOld.Text;
        }

        private void txtNew_TextChanged(object sender, EventArgs e)
        {
            NewString = txtNew.Text;
        }

    }
}
