namespace WhatForensics
{
    partial class GroupMembersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupMembersView));
            this.lbGroupMembers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbGroupMembers
            // 
            this.lbGroupMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGroupMembers.FormattingEnabled = true;
            this.lbGroupMembers.Location = new System.Drawing.Point(2, 3);
            this.lbGroupMembers.Name = "lbGroupMembers";
            this.lbGroupMembers.Size = new System.Drawing.Size(287, 264);
            this.lbGroupMembers.TabIndex = 0;
            // 
            // GroupMembersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.lbGroupMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GroupMembersView";
            this.Text = "Group Members for ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbGroupMembers;
    }
}