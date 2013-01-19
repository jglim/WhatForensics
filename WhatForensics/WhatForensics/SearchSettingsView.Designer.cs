namespace WhatForensics
{
    partial class SearchSettingsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSettingsView));
            this.txtSearchQuery = new System.Windows.Forms.TextBox();
            this.lblDescQuery = new System.Windows.Forms.Label();
            this.lblDescOperators = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearchQuery
            // 
            this.txtSearchQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchQuery.Location = new System.Drawing.Point(65, 12);
            this.txtSearchQuery.Name = "txtSearchQuery";
            this.txtSearchQuery.Size = new System.Drawing.Size(271, 20);
            this.txtSearchQuery.TabIndex = 0;
            this.txtSearchQuery.Text = "%%";
            this.txtSearchQuery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchQuery_KeyPress);
            // 
            // lblDescQuery
            // 
            this.lblDescQuery.AutoSize = true;
            this.lblDescQuery.Location = new System.Drawing.Point(12, 15);
            this.lblDescQuery.Name = "lblDescQuery";
            this.lblDescQuery.Size = new System.Drawing.Size(38, 13);
            this.lblDescQuery.TabIndex = 1;
            this.lblDescQuery.Text = "Query:";
            // 
            // lblDescOperators
            // 
            this.lblDescOperators.AutoSize = true;
            this.lblDescOperators.Location = new System.Drawing.Point(12, 61);
            this.lblDescOperators.Name = "lblDescOperators";
            this.lblDescOperators.Size = new System.Drawing.Size(177, 91);
            this.lblDescOperators.TabIndex = 2;
            this.lblDescOperators.Text = "You may use SQLite LIKE syntax:\r\n% as \"any characters\"\r\n_ as single character wil" +
                "dcard\r\n%http://% for URLs\r\n\r\n\r\nnot using %% for exact matches etc.";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(342, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchSettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 168);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDescOperators);
            this.Controls.Add(this.lblDescQuery);
            this.Controls.Add(this.txtSearchQuery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchSettingsView";
            this.Text = "Search Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchQuery;
        private System.Windows.Forms.Label lblDescQuery;
        private System.Windows.Forms.Label lblDescOperators;
        private System.Windows.Forms.Button btnSearch;
    }
}