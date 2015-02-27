namespace FileRename.Controls
{
    partial class FileRenamedPreview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOldFileName = new System.Windows.Forms.TextBox();
            this.txtNewFileName = new System.Windows.Forms.TextBox();
            this.chkIsReName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOldFileName
            // 
            this.txtOldFileName.Enabled = false;
            this.txtOldFileName.Location = new System.Drawing.Point(29, 1);
            this.txtOldFileName.Name = "txtOldFileName";
            this.txtOldFileName.Size = new System.Drawing.Size(206, 20);
            this.txtOldFileName.TabIndex = 0;
            // 
            // txtNewFileName
            // 
            this.txtNewFileName.Location = new System.Drawing.Point(258, 1);
            this.txtNewFileName.Name = "txtNewFileName";
            this.txtNewFileName.Size = new System.Drawing.Size(220, 20);
            this.txtNewFileName.TabIndex = 1;
            this.txtNewFileName.TextChanged += new System.EventHandler(this.txtNewFileName_TextChanged);
            // 
            // chkIsReName
            // 
            this.chkIsReName.AutoSize = true;
            this.chkIsReName.Location = new System.Drawing.Point(8, 4);
            this.chkIsReName.Name = "chkIsReName";
            this.chkIsReName.Size = new System.Drawing.Size(15, 14);
            this.chkIsReName.TabIndex = 2;
            this.chkIsReName.UseVisualStyleBackColor = true;
            this.chkIsReName.CheckedChanged += new System.EventHandler(this.chkIsReName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "-->";
            // 
            // FileRenamedPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkIsReName);
            this.Controls.Add(this.txtNewFileName);
            this.Controls.Add(this.txtOldFileName);
            this.Name = "FileRenamedPreview";
            this.Size = new System.Drawing.Size(482, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldFileName;
        private System.Windows.Forms.TextBox txtNewFileName;
        private System.Windows.Forms.CheckBox chkIsReName;
        private System.Windows.Forms.Label label1;
    }
}
