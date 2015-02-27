namespace FileRename
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBrowser = new System.Windows.Forms.Button();
            this.lblFolderPAth = new System.Windows.Forms.Label();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnRenameFiles = new System.Windows.Forms.Button();
            this.lstRenameFile = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOld1 = new System.Windows.Forms.TextBox();
            this.txtOld2 = new System.Windows.Forms.TextBox();
            this.txtNew1 = new System.Windows.Forms.TextBox();
            this.txtNew2 = new System.Windows.Forms.TextBox();
            this.btnPReview = new System.Windows.Forms.Button();
            this.lblProcessDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(194, 7);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(108, 23);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "Browse Folder";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // lblFolderPAth
            // 
            this.lblFolderPAth.AutoSize = true;
            this.lblFolderPAth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolderPAth.Location = new System.Drawing.Point(308, 8);
            this.lblFolderPAth.Name = "lblFolderPAth";
            this.lblFolderPAth.Size = new System.Drawing.Size(0, 18);
            this.lblFolderPAth.TabIndex = 1;
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(13, 42);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(218, 158);
            this.lstFiles.TabIndex = 2;
            // 
            // btnRenameFiles
            // 
            this.btnRenameFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRenameFiles.Location = new System.Drawing.Point(143, 214);
            this.btnRenameFiles.Name = "btnRenameFiles";
            this.btnRenameFiles.Size = new System.Drawing.Size(125, 23);
            this.btnRenameFiles.TabIndex = 3;
            this.btnRenameFiles.Text = "Rename All Files";
            this.btnRenameFiles.UseVisualStyleBackColor = true;
            this.btnRenameFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstRenameFile
            // 
            this.lstRenameFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRenameFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRenameFile.FormattingEnabled = true;
            this.lstRenameFile.Location = new System.Drawing.Point(436, 42);
            this.lstRenameFile.Name = "lstRenameFile";
            this.lstRenameFile.Size = new System.Drawing.Size(203, 158);
            this.lstRenameFile.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Old";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "New";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(108, 9);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(57, 20);
            this.txtExtension.TabIndex = 7;
            this.txtExtension.Text = "*.*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filter pattern of file:";
            // 
            // txtOld1
            // 
            this.txtOld1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOld1.Location = new System.Drawing.Point(241, 59);
            this.txtOld1.Name = "txtOld1";
            this.txtOld1.Size = new System.Drawing.Size(82, 20);
            this.txtOld1.TabIndex = 9;
            // 
            // txtOld2
            // 
            this.txtOld2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOld2.Location = new System.Drawing.Point(241, 85);
            this.txtOld2.Name = "txtOld2";
            this.txtOld2.Size = new System.Drawing.Size(82, 20);
            this.txtOld2.TabIndex = 10;
            // 
            // txtNew1
            // 
            this.txtNew1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNew1.Location = new System.Drawing.Point(341, 58);
            this.txtNew1.Name = "txtNew1";
            this.txtNew1.Size = new System.Drawing.Size(83, 20);
            this.txtNew1.TabIndex = 11;
            // 
            // txtNew2
            // 
            this.txtNew2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNew2.Location = new System.Drawing.Point(341, 85);
            this.txtNew2.Name = "txtNew2";
            this.txtNew2.Size = new System.Drawing.Size(83, 20);
            this.txtNew2.TabIndex = 12;
            // 
            // btnPReview
            // 
            this.btnPReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPReview.Location = new System.Drawing.Point(12, 214);
            this.btnPReview.Name = "btnPReview";
            this.btnPReview.Size = new System.Drawing.Size(125, 23);
            this.btnPReview.TabIndex = 13;
            this.btnPReview.Text = "Preview File Name";
            this.btnPReview.UseVisualStyleBackColor = true;
            this.btnPReview.Click += new System.EventHandler(this.btnPReview_Click);
            // 
            // lblProcessDescription
            // 
            this.lblProcessDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProcessDescription.AutoSize = true;
            this.lblProcessDescription.Location = new System.Drawing.Point(288, 219);
            this.lblProcessDescription.Name = "lblProcessDescription";
            this.lblProcessDescription.Size = new System.Drawing.Size(35, 13);
            this.lblProcessDescription.TabIndex = 14;
            this.lblProcessDescription.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 249);
            this.Controls.Add(this.lblProcessDescription);
            this.Controls.Add(this.btnPReview);
            this.Controls.Add(this.txtNew2);
            this.Controls.Add(this.txtNew1);
            this.Controls.Add(this.txtOld2);
            this.Controls.Add(this.txtOld1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRenameFile);
            this.Controls.Add(this.btnRenameFiles);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.lblFolderPAth);
            this.Controls.Add(this.btnBrowser);
            this.Name = "Form1";
            this.Text = "File Ranamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label lblFolderPAth;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnRenameFiles;
        private System.Windows.Forms.ListBox lstRenameFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOld1;
        private System.Windows.Forms.TextBox txtOld2;
        private System.Windows.Forms.TextBox txtNew1;
        private System.Windows.Forms.TextBox txtNew2;
        private System.Windows.Forms.Button btnPReview;
        private System.Windows.Forms.Label lblProcessDescription;
    }
}

