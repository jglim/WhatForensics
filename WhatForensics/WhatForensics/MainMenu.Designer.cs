namespace WhatForensics
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDetailDescription = new System.Windows.Forms.TextBox();
            this.txtDetalHeaders = new System.Windows.Forms.TextBox();
            this.lbConversationList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWhatsAppDatabaseLocallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.acquireWhatsAppDatabaseFromIOSDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acquireWhatsAppDBFromITunesDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitWhatForensicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wABlacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knownIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutWhatForensicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtDetailDescription);
            this.panel1.Controls.Add(this.txtDetalHeaders);
            this.panel1.Controls.Add(this.lbConversationList);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 389);
            this.panel1.TabIndex = 1;
            // 
            // txtDetailDescription
            // 
            this.txtDetailDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetailDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetailDescription.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetailDescription.Location = new System.Drawing.Point(403, 4);
            this.txtDetailDescription.Multiline = true;
            this.txtDetailDescription.Name = "txtDetailDescription";
            this.txtDetailDescription.ReadOnly = true;
            this.txtDetailDescription.Size = new System.Drawing.Size(542, 368);
            this.txtDetailDescription.TabIndex = 2;
            // 
            // txtDetalHeaders
            // 
            this.txtDetalHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDetalHeaders.BackColor = System.Drawing.SystemColors.Control;
            this.txtDetalHeaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetalHeaders.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalHeaders.Location = new System.Drawing.Point(188, 4);
            this.txtDetalHeaders.Multiline = true;
            this.txtDetalHeaders.Name = "txtDetalHeaders";
            this.txtDetalHeaders.ReadOnly = true;
            this.txtDetalHeaders.Size = new System.Drawing.Size(209, 375);
            this.txtDetalHeaders.TabIndex = 1;
            this.txtDetalHeaders.Text = resources.GetString("txtDetalHeaders.Text");
            // 
            // lbConversationList
            // 
            this.lbConversationList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbConversationList.FormattingEnabled = true;
            this.lbConversationList.Location = new System.Drawing.Point(3, 3);
            this.lbConversationList.Name = "lbConversationList";
            this.lbConversationList.Size = new System.Drawing.Size(178, 355);
            this.lbConversationList.TabIndex = 0;
            this.lbConversationList.SelectedIndexChanged += new System.EventHandler(this.lbConversationList_SelectedIndexChanged);
            this.lbConversationList.DoubleClick += new System.EventHandler(this.lbConversationList_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadWhatsAppDatabaseLocallyToolStripMenuItem,
            this.toolStripSeparator1,
            this.acquireWhatsAppDatabaseFromIOSDeviceToolStripMenuItem,
            this.acquireWhatsAppDBFromITunesDBToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitWhatForensicsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadWhatsAppDatabaseLocallyToolStripMenuItem
            // 
            this.loadWhatsAppDatabaseLocallyToolStripMenuItem.Name = "loadWhatsAppDatabaseLocallyToolStripMenuItem";
            this.loadWhatsAppDatabaseLocallyToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.loadWhatsAppDatabaseLocallyToolStripMenuItem.Text = "Load WhatsApp DB from file";
            this.loadWhatsAppDatabaseLocallyToolStripMenuItem.Click += new System.EventHandler(this.loadWhatsAppDatabaseLocallyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(276, 6);
            // 
            // acquireWhatsAppDatabaseFromIOSDeviceToolStripMenuItem
            // 
            this.acquireWhatsAppDatabaseFromIOSDeviceToolStripMenuItem.Name = "acquireWhatsAppDatabaseFromIOSDeviceToolStripMenuItem";
            this.acquireWhatsAppDatabaseFromIOSDeviceToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.acquireWhatsAppDatabaseFromIOSDeviceToolStripMenuItem.Text = "Acquire WhatsApp DB from iOS Device";
            this.acquireWhatsAppDatabaseFromIOSDeviceToolStripMenuItem.Click += new System.EventHandler(this.acquireWhatsAppDatabaseFromIOSDeviceToolStripMenuItem_Click);
            // 
            // acquireWhatsAppDBFromITunesDBToolStripMenuItem
            // 
            this.acquireWhatsAppDBFromITunesDBToolStripMenuItem.Name = "acquireWhatsAppDBFromITunesDBToolStripMenuItem";
            this.acquireWhatsAppDBFromITunesDBToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.acquireWhatsAppDBFromITunesDBToolStripMenuItem.Text = "Acquire WhatsApp DB from iTunes DB";
            this.acquireWhatsAppDBFromITunesDBToolStripMenuItem.Click += new System.EventHandler(this.acquireWhatsAppDBFromITunesDBToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(276, 6);
            // 
            // exitWhatForensicsToolStripMenuItem
            // 
            this.exitWhatForensicsToolStripMenuItem.Name = "exitWhatForensicsToolStripMenuItem";
            this.exitWhatForensicsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitWhatForensicsToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.exitWhatForensicsToolStripMenuItem.Text = "Exit WhatForensics";
            this.exitWhatForensicsToolStripMenuItem.Click += new System.EventHandler(this.exitWhatForensicsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupMembersToolStripMenuItem,
            this.wABlacklistToolStripMenuItem,
            this.toolStripSeparator3,
            this.searchToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // groupMembersToolStripMenuItem
            // 
            this.groupMembersToolStripMenuItem.Name = "groupMembersToolStripMenuItem";
            this.groupMembersToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.groupMembersToolStripMenuItem.Text = "Group Members";
            this.groupMembersToolStripMenuItem.Click += new System.EventHandler(this.groupMembersToolStripMenuItem_Click);
            // 
            // wABlacklistToolStripMenuItem
            // 
            this.wABlacklistToolStripMenuItem.Name = "wABlacklistToolStripMenuItem";
            this.wABlacklistToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.wABlacklistToolStripMenuItem.Text = "WA Blacklist";
            this.wABlacklistToolStripMenuItem.Click += new System.EventHandler(this.wABlacklistToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knownIssuesToolStripMenuItem,
            this.aboutWhatForensicsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // knownIssuesToolStripMenuItem
            // 
            this.knownIssuesToolStripMenuItem.Name = "knownIssuesToolStripMenuItem";
            this.knownIssuesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.knownIssuesToolStripMenuItem.Text = "Known Issues";
            this.knownIssuesToolStripMenuItem.Click += new System.EventHandler(this.knownIssuesToolStripMenuItem_Click);
            // 
            // aboutWhatForensicsToolStripMenuItem
            // 
            this.aboutWhatForensicsToolStripMenuItem.Name = "aboutWhatForensicsToolStripMenuItem";
            this.aboutWhatForensicsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aboutWhatForensicsToolStripMenuItem.Text = "About WhatForensics";
            this.aboutWhatForensicsToolStripMenuItem.Click += new System.EventHandler(this.aboutWhatForensicsToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "WhatForensics";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbConversationList;
        private System.Windows.Forms.TextBox txtDetalHeaders;
        private System.Windows.Forms.TextBox txtDetailDescription;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWhatsAppDatabaseLocallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acquireWhatsAppDatabaseFromIOSDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acquireWhatsAppDBFromITunesDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitWhatForensicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wABlacklistToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knownIssuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutWhatForensicsToolStripMenuItem;
    }
}

