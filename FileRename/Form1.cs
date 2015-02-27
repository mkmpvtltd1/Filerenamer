using FileRename.Controls;
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
        List<Replacer> lstReplacer = new List<Replacer>();
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
        txtExtension.Text.Trim(),
       SearchOption.TopDirectoryOnly).ToList();
            // Display all the files.
            List<string> fileName = new List<string>();
            foreach (string file in files)
            {
                fileName.Add(Path.GetFileName(file));
            }
            for (int i = 0; i < fileName.Count; i++)
            {
                FileRenamedPreview obj = new FileRenamedPreview(fileName[i], fileName[i]) { Location = new Point(0, 20 * i + 20) };
                pnlViewer.Controls.Add(obj);
            }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Replacer obj = new Replacer();
            lstReplacer.Add(obj);
            bindReplacer();
        }

        private void bindReplacer()
        {
            for (int i = 0; i < lstReplacer.Count; i++)
            {
                lstReplacer[i].Location = new Point(2, i * 20 + 20);
                pnlReplacer.Controls.Add(lstReplacer[i]);
            }
        }


    }
}
