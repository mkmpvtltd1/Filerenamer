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
    public partial class FileRenamedPreview : UserControl
    {
        public string NewFileName { get; set; }
        public string OldFileName { get; set; }
        public bool IsChange { get; set; }
        public FileRenamedPreview()
        {
            InitializeComponent();
        }
        public FileRenamedPreview(string OldFileName, string NewFileName)
        {
            InitializeComponent();
            this.NewFileName = NewFileName;
            this.OldFileName = OldFileName;
            txtNewFileName.Text = NewFileName;
            txtOldFileName.Text = OldFileName;
        }

        private void txtNewFileName_TextChanged(object sender, EventArgs e)
        {
            this.NewFileName = txtNewFileName.Text;
        }

        private void chkIsReName_CheckedChanged(object sender, EventArgs e)
        {
            IsChange = chkIsReName.Checked;
        }
    }
}
