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
        string SelectedPath = string.Empty;
        List<string> files = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog obj = new FolderBrowserDialog();
            obj.SelectedPath = SelectedPath;
            DialogResult dr = obj.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                lblFolderPAth.Text = obj.SelectedPath;
                SelectedPath = obj.SelectedPath;
                GetAllFileName();
            }
        }

        private void GetAllFileName()
        {
            files = Directory.GetFiles(SelectedPath,
       "*." + txtExtension.Text.Trim(),
       SearchOption.TopDirectoryOnly).ToList();
            // Display all the files.
            List<string> fileName = new List<string>();
            foreach (string file in files)
            {
                fileName.Add(Path.GetFileName(file));
            }
            lstFiles.DataSource = fileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string file in files)
            {
                if (File.Exists(file))
                {
                    Path.GetFileName(file);
                    string OldFilePath = file;
                    string NewFilePath = SelectedPath + "\\" + Path.GetFileName(file).Replace(txtOld1.Text, txtNew1.Text).Replace(txtOld2.Text, txtNew2.Text);
                    File.Move(OldFilePath, NewFilePath);
                    lblProcessDescription.Text = OldFilePath + " To " + NewFilePath;
                }
            }
        }

        private void btnPReview_Click(object sender, EventArgs e)
        {
            // Display all the files.
            List<string> fileName = new List<string>();
            foreach (string file in files)
            {
                fileName.Add(Path.GetFileName(file).Replace(txtOld1.Text, txtNew1.Text).Replace(txtOld2.Text, txtNew2.Text));
            }
            lstRenameFile.DataSource = fileName;
        }
    }
}
