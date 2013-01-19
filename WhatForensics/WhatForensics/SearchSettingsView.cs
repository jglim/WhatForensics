using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhatForensics
{
    public partial class SearchSettingsView : Form
    {
        public SearchSettingsView()
        {
            InitializeComponent();
        }

        public string connectionString = "";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            performSearch();
        }

        private void performSearch() 
        {
            MessageView messageView = new MessageView();
            messageView.Text = "Search results for " + txtSearchQuery.Text;

            messageView.IsGroupMessage = false;
            messageView.InitializeMessages(0, connectionString, txtSearchQuery.Text);
            messageView.Show();

            this.Close();
        
        }

        private void txtSearchQuery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
            {
                e.Handled = true;
                performSearch();
            }

        }
    }
}
