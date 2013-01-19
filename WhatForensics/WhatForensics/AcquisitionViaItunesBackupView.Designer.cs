namespace WhatForensics
{
    partial class AcquisitionViaItunesBackupView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcquisitionViaItunesBackupView));
            this.chkUseMachineBackups = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cbBackupList = new System.Windows.Forms.ComboBox();
            this.btnAcquire = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDescriptionData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkUseMachineBackups
            // 
            this.chkUseMachineBackups.AutoSize = true;
            this.chkUseMachineBackups.Checked = true;
            this.chkUseMachineBackups.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseMachineBackups.Location = new System.Drawing.Point(12, 12);
            this.chkUseMachineBackups.Name = "chkUseMachineBackups";
            this.chkUseMachineBackups.Size = new System.Drawing.Size(209, 17);
            this.chkUseMachineBackups.TabIndex = 0;
            this.chkUseMachineBackups.Text = "Use iTunes Backup from this computer";
            this.chkUseMachineBackups.UseVisualStyleBackColor = true;
            this.chkUseMachineBackups.CheckedChanged += new System.EventHandler(this.chkUseMachineBackups_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Enabled = false;
            this.btnBrowse.Location = new System.Drawing.Point(329, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(152, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse for Backup folder";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cbBackupList
            // 
            this.cbBackupList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBackupList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBackupList.FormattingEnabled = true;
            this.cbBackupList.Location = new System.Drawing.Point(12, 41);
            this.cbBackupList.Name = "cbBackupList";
            this.cbBackupList.Size = new System.Drawing.Size(550, 21);
            this.cbBackupList.TabIndex = 2;
            this.cbBackupList.SelectedIndexChanged += new System.EventHandler(this.cbBackupList_SelectedIndexChanged);
            // 
            // btnAcquire
            // 
            this.btnAcquire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcquire.Location = new System.Drawing.Point(487, 12);
            this.btnAcquire.Name = "btnAcquire";
            this.btnAcquire.Size = new System.Drawing.Size(75, 23);
            this.btnAcquire.TabIndex = 3;
            this.btnAcquire.Text = "Acquire";
            this.btnAcquire.UseVisualStyleBackColor = true;
            this.btnAcquire.Click += new System.EventHandler(this.btnAcquire_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(12, 68);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(209, 210);
            this.txtDescription.TabIndex = 4;
            // 
            // txtDescriptionData
            // 
            this.txtDescriptionData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescriptionData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescriptionData.Location = new System.Drawing.Point(227, 68);
            this.txtDescriptionData.Multiline = true;
            this.txtDescriptionData.Name = "txtDescriptionData";
            this.txtDescriptionData.ReadOnly = true;
            this.txtDescriptionData.Size = new System.Drawing.Size(335, 210);
            this.txtDescriptionData.TabIndex = 5;
            // 
            // AcquisitionViaItunesBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 290);
            this.Controls.Add(this.txtDescriptionData);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnAcquire);
            this.Controls.Add(this.cbBackupList);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.chkUseMachineBackups);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AcquisitionViaItunesBackup";
            this.Text = "Acquisition via iTunes Backup";
            this.Load += new System.EventHandler(this.AcquisitionViaItunesBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUseMachineBackups;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cbBackupList;
        private System.Windows.Forms.Button btnAcquire;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDescriptionData;
    }
}