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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlReplacer = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstTrim = new System.Windows.Forms.MaskedTextBox();
            this.txtLastTrim = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlViewer = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.pnlReplacer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackColor = System.Drawing.Color.Silver;
            this.btnBrowser.FlatAppearance.BorderSize = 0;
            this.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowser.Location = new System.Drawing.Point(171, 9);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(86, 20);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "Browse Folder";
            this.btnBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // lblFolderPAth
            // 
            this.lblFolderPAth.AutoSize = true;
            this.lblFolderPAth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFolderPAth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolderPAth.Location = new System.Drawing.Point(266, 10);
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
            this.lstFiles.Location = new System.Drawing.Point(13, 338);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(218, 119);
            this.lstFiles.TabIndex = 2;
            // 
            // btnRenameFiles
            // 
            this.btnRenameFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRenameFiles.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRenameFiles.FlatAppearance.BorderSize = 0;
            this.btnRenameFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenameFiles.Location = new System.Drawing.Point(143, 465);
            this.btnRenameFiles.Name = "btnRenameFiles";
            this.btnRenameFiles.Size = new System.Drawing.Size(125, 23);
            this.btnRenameFiles.TabIndex = 3;
            this.btnRenameFiles.Text = "Rename All Files";
            this.btnRenameFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenameFiles.UseVisualStyleBackColor = false;
            this.btnRenameFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstRenameFile
            // 
            this.lstRenameFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRenameFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRenameFile.FormattingEnabled = true;
            this.lstRenameFile.Location = new System.Drawing.Point(436, 338);
            this.lstRenameFile.Name = "lstRenameFile";
            this.lstRenameFile.Size = new System.Drawing.Size(203, 119);
            this.lstRenameFile.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 391);
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
            this.label2.Location = new System.Drawing.Point(338, 391);
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
            this.txtOld1.Location = new System.Drawing.Point(241, 408);
            this.txtOld1.Name = "txtOld1";
            this.txtOld1.Size = new System.Drawing.Size(82, 20);
            this.txtOld1.TabIndex = 9;
            // 
            // txtOld2
            // 
            this.txtOld2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOld2.Location = new System.Drawing.Point(241, 437);
            this.txtOld2.Name = "txtOld2";
            this.txtOld2.Size = new System.Drawing.Size(82, 20);
            this.txtOld2.TabIndex = 10;
            // 
            // txtNew1
            // 
            this.txtNew1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNew1.Location = new System.Drawing.Point(341, 407);
            this.txtNew1.Name = "txtNew1";
            this.txtNew1.Size = new System.Drawing.Size(83, 20);
            this.txtNew1.TabIndex = 11;
            // 
            // txtNew2
            // 
            this.txtNew2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNew2.Location = new System.Drawing.Point(341, 437);
            this.txtNew2.Name = "txtNew2";
            this.txtNew2.Size = new System.Drawing.Size(83, 20);
            this.txtNew2.TabIndex = 12;
            // 
            // btnPReview
            // 
            this.btnPReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPReview.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPReview.FlatAppearance.BorderSize = 0;
            this.btnPReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPReview.Location = new System.Drawing.Point(287, 119);
            this.btnPReview.Name = "btnPReview";
            this.btnPReview.Size = new System.Drawing.Size(125, 23);
            this.btnPReview.TabIndex = 13;
            this.btnPReview.Text = "Preview File Name";
            this.btnPReview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPReview.UseVisualStyleBackColor = false;
            this.btnPReview.Click += new System.EventHandler(this.btnPReview_Click);
            // 
            // lblProcessDescription
            // 
            this.lblProcessDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProcessDescription.AutoSize = true;
            this.lblProcessDescription.Location = new System.Drawing.Point(288, 470);
            this.lblProcessDescription.Name = "lblProcessDescription";
            this.lblProcessDescription.Size = new System.Drawing.Size(35, 13);
            this.lblProcessDescription.TabIndex = 14;
            this.lblProcessDescription.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnPReview);
            this.groupBox1.Controls.Add(this.txtLastTrim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFirstTrim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pnlReplacer);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 149);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change File Name";
            // 
            // pnlReplacer
            // 
            this.pnlReplacer.AutoScroll = true;
            this.pnlReplacer.Controls.Add(this.label7);
            this.pnlReplacer.Location = new System.Drawing.Point(7, 35);
            this.pnlReplacer.Name = "pnlReplacer";
            this.pnlReplacer.Size = new System.Drawing.Size(262, 107);
            this.pnlReplacer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trim First Letters :";
            // 
            // txtFirstTrim
            // 
            this.txtFirstTrim.Location = new System.Drawing.Point(371, 14);
            this.txtFirstTrim.Name = "txtFirstTrim";
            this.txtFirstTrim.Size = new System.Drawing.Size(26, 20);
            this.txtFirstTrim.TabIndex = 16;
            this.txtFirstTrim.Text = "0";
            // 
            // txtLastTrim
            // 
            this.txtLastTrim.Location = new System.Drawing.Point(371, 36);
            this.txtLastTrim.Name = "txtLastTrim";
            this.txtLastTrim.Size = new System.Drawing.Size(26, 20);
            this.txtLastTrim.TabIndex = 18;
            this.txtLastTrim.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Trim Last Letters :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "String Replacer :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "New Text                    -->  Old Text";
            // 
            // pnlViewer
            // 
            this.pnlViewer.AutoScroll = true;
            this.pnlViewer.Location = new System.Drawing.Point(15, 184);
            this.pnlViewer.Name = "pnlViewer";
            this.pnlViewer.Size = new System.Drawing.Size(624, 148);
            this.pnlViewer.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 500);
            this.Controls.Add(this.pnlViewer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProcessDescription);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlReplacer.ResumeLayout(false);
            this.pnlReplacer.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlReplacer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtLastTrim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtFirstTrim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlViewer;
    }
}

