namespace PGPEncrypter
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnEncryptRootPlusSubFolders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDecryptSingleFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncryptSingleFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDecryptRootPlusSubFolders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncryptRootPlusSubFolders
            // 
            this.btnEncryptRootPlusSubFolders.Location = new System.Drawing.Point(107, 37);
            this.btnEncryptRootPlusSubFolders.Name = "btnEncryptRootPlusSubFolders";
            this.btnEncryptRootPlusSubFolders.Size = new System.Drawing.Size(121, 23);
            this.btnEncryptRootPlusSubFolders.TabIndex = 0;
            this.btnEncryptRootPlusSubFolders.Text = "Choose Base Folder";
            this.btnEncryptRootPlusSubFolders.UseVisualStyleBackColor = true;
            this.btnEncryptRootPlusSubFolders.Click += new System.EventHandler(this.btnEncryptRootPlusSubFolders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encrypt File(s)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop/Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(53, 136);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDecryptSingleFile
            // 
            this.btnDecryptSingleFile.Location = new System.Drawing.Point(107, 248);
            this.btnDecryptSingleFile.Name = "btnDecryptSingleFile";
            this.btnDecryptSingleFile.Size = new System.Drawing.Size(228, 23);
            this.btnDecryptSingleFile.TabIndex = 6;
            this.btnDecryptSingleFile.Text = "Choose an encrypted File to decrypt";
            this.btnDecryptSingleFile.UseVisualStyleBackColor = true;
            this.btnDecryptSingleFile.Click += new System.EventHandler(this.btnDecryptSingleFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // btnEncryptSingleFile
            // 
            this.btnEncryptSingleFile.Location = new System.Drawing.Point(107, 66);
            this.btnEncryptSingleFile.Name = "btnEncryptSingleFile";
            this.btnEncryptSingleFile.Size = new System.Drawing.Size(121, 23);
            this.btnEncryptSingleFile.TabIndex = 8;
            this.btnEncryptSingleFile.Text = "Choose a file";
            this.btnEncryptSingleFile.UseVisualStyleBackColor = true;
            this.btnEncryptSingleFile.Click += new System.EventHandler(this.btnEncryptSingleFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "(All files under this folder and subfolders would be encrypted)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "(A single file would be encrypted)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Decrypt File(s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "(All files under this folder and subfolders would be decrypted)";
            // 
            // btnDecryptRootPlusSubFolders
            // 
            this.btnDecryptRootPlusSubFolders.Location = new System.Drawing.Point(107, 212);
            this.btnDecryptRootPlusSubFolders.Name = "btnDecryptRootPlusSubFolders";
            this.btnDecryptRootPlusSubFolders.Size = new System.Drawing.Size(121, 23);
            this.btnDecryptRootPlusSubFolders.TabIndex = 12;
            this.btnDecryptRootPlusSubFolders.Text = "Choose Base Folder";
            this.btnDecryptRootPlusSubFolders.UseVisualStyleBackColor = true;
            this.btnDecryptRootPlusSubFolders.Click += new System.EventHandler(this.btnDecryptRootPlusSubFolders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 324);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDecryptRootPlusSubFolders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEncryptSingleFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDecryptSingleFile);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncryptRootPlusSubFolders);
            this.Name = "Form1";
            this.Text = "Form1- Last modified 06/06/2016";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnEncryptRootPlusSubFolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDecryptSingleFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncryptSingleFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDecryptRootPlusSubFolders;
    }
}

