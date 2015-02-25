using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRename
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog obj = new FolderBrowserDialog();
            DialogResult dr = obj.ShowDialog();
            lblFolderPAth.Text = obj.SelectedPath;
            GetAllFileName(obj.SelectedPath);
        }

        private void GetAllFileName(string SelectedPath)
        {
            string[] files = Directory.GetFiles(SelectedPath,
        "*.*",
        SearchOption.AllDirectories);
            // Display all the files.
            List<string> fileName = new List<string>();
            foreach (string file in files)
            {
                fileName.Add(Path.GetFileName(file));
            }
            lstFiles.DataSource = fileName;
        }
    }
}
