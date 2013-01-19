using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;


namespace WhatForensics
{
    public partial class MessageView : Form
    {
        public MessageView()
        {
            InitializeComponent();
        }

        public bool IsGroupMessage = false;

        public void InitializeMessages(int zchatsession, string connectionString, string searchString = "") 
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            string queryString = "select z_pk from zwamessage where zchatsession = " + zchatsession.ToString() + " order by zmessagedate asc";
            if (searchString != "") 
            { 
                //search performed!

                // hopefully nobody tries anything funny here
                queryString = "select z_pk from zwamessage where ztext like \"" + searchString+ "\" order by zmessagedate asc";
            }
            SQLiteCommand command = new SQLiteCommand(queryString, connection);

            lvMessageView.Items.Clear();

            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    WAMessage currentMessage = new WAMessage(Convert.ToInt32(reader[0]), connectionString);

                    WAGroupMember messageOwner = new WAGroupMember(currentMessage.ZGROUPMEMBER, connectionString);

                    ListViewItem currentListViewItem;

                    if (currentMessage.ZISFROMME == 1)
                    {
                        currentListViewItem = new ListViewItem("WhatsApp Owner");
                    }
                    else 
                    {
                        string messageOwnerName = "";



                        // appending again somehow fixes the blank string problem
                        messageOwnerName += messageOwner.ZCONTACTNAME;

                        //if (messageOwnerName.Length == 0 && IsGroupMessage == false) 
                        //{
                        //    //messageOwnerName = "Hello";
                        //}

                        //hackish but works
                        bool isNotOwner = true;
                        if (messageOwnerName.Length == 0) 
                        {
                            messageOwnerName = this.Text;
                            isNotOwner = true;
                        }
                        currentListViewItem = new ListViewItem(messageOwnerName);

                        //really wtf?
                        if (isNotOwner)
                        {
                            currentListViewItem.BackColor = Color.Wheat;
                        }

                        
                    }

                    
                    currentListViewItem.SubItems.Add(currentMessage.ZTEXT);
                    currentListViewItem.SubItems.Add(MiscHelper.HandleWeirdEpochAddTimezoneInformation(currentMessage.ZMESSAGEDATE));

                    string eventType = "";
                    if (currentMessage.Z_GROUPEVENTTYPE == 0) 
                    {
                        eventType = "Message";
                    }
                    else if (currentMessage.Z_GROUPEVENTTYPE == 1) 
                    {
                        eventType = "Group Creation";
                    }
                    else if (currentMessage.Z_GROUPEVENTTYPE == 2)
                    {
                        eventType = "Joined Group";
                    }
                    else if (currentMessage.Z_GROUPEVENTTYPE == 3)
                    {
                        eventType = "Left Group";
                    }
                    else 
                    {
                        eventType = "Unknown (" + currentMessage.Z_GROUPEVENTTYPE.ToString() + ")";
                    }

                    currentListViewItem.SubItems.Add(eventType);

                    lvMessageView.Items.Add(currentListViewItem);
                    

                }
                reader.Close();


            }
            catch (Exception ex)
            {
                // oh no
            }
        }

        private void lvMessageView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string exportTemplate = System.IO.File.ReadAllText(Application.StartupPath + "\\uni.html");
            exportTemplate = exportTemplate.Replace("%exportusername%", txtName.Text);
            exportTemplate = exportTemplate.Replace("%dategenerated%", DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
            exportTemplate = exportTemplate.Replace("%threadname%", this.Text);
            exportTemplate = exportTemplate.Replace("%filename%", MiscHelper.currentlyOpenFilePath);

            StringBuilder tableData = new StringBuilder("");
            for (int i = 0; i < lvMessageView.Items.Count; i++) 
            {
                string combinedMessageEvent = lvMessageView.Items[i].Text;
                if (lvMessageView.Items[i].SubItems[3].Text != "Message") 
                {
                    combinedMessageEvent = lvMessageView.Items[i].SubItems[3].Text;
                }
                string tableRow = "<tr class=\"success\"><td>" + i.ToString() + "</td><td>" + combinedMessageEvent + "</td><td>" + lvMessageView.Items[i].SubItems[1].Text + "</td><td>" + lvMessageView.Items[i].SubItems[2].Text + "</td></tr>";
                if (lvMessageView.Items[i].BackColor != Color.Wheat)
                {
                    tableRow = tableRow.Replace("success", "");
                }

                tableData.Append(tableRow);
            }

            exportTemplate = exportTemplate.Replace("%tabledata%", tableData.ToString());

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML Files | *.html";
            sfd.Title = "Export Log";
            if (sfd.ShowDialog() == DialogResult.OK) 
            {
                System.IO.File.WriteAllText(sfd.FileName, exportTemplate);
                MessageBox.Show("Export complete!");
            }


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (MiscHelper.investigatorName != "Investigator Name") 
            {
                MiscHelper.investigatorName = txtName.Text;
            }
            
        }

        bool isNameSet = false;

        private void MessageView_Load(object sender, EventArgs e)
        {
            txtName.Text = MiscHelper.investigatorName;
        }

    }
}
