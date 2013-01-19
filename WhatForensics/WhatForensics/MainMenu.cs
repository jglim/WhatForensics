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
    public partial class MainMenu : Form
    {

        string connectionString = "Data Source=%;Version=3;Read Only=True;";

        
        bool isDatabaseLoaded = false;
        GroupMembersView groupMembersView;
        int selectedConversationPk = 0;
        bool selectedConversationIsGroup = false;

        public MainMenu()
        {
            InitializeComponent();
        }


        //datetime(zmessagedate, 'unixepoch', 'localtime') fixes all date issues!
        private void Main_Load(object sender, EventArgs e)
        {
            // see if loading sqlite db

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            { 
                if (System.IO.File.Exists(args[1]))
                {
                    LoadDatabase(args[1]);
                }
            }

            // disable some stuff that shouldn't be able to start w/o db
            viewToolStripMenuItem.Enabled = false;

        }


        private void lbConversationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbConversationList.Items.Count == 0) 
            {
                return;
            }

            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand("select * from zwachatsession order by zlastmessagedate desc limit 1 offset " + lbConversationList.SelectedIndex.ToString(), connection);

            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                string result = "";

                while (reader.Read())
                {
                    WAMessage getLastMessage = new WAMessage(Convert.ToInt32(reader[8]), connectionString);
                    if (reader[7].ToString().Length != 0)
                    {
                        CreateOrRemakeGroupMembersView();
                        groupMembersView.ClearListOfUsersInGroup();
                        groupMembersView.Text = "Group members for " + reader[13].ToString();
                        groupMembersView.DrawListOfUsersInGroup(Convert.ToInt32(reader[0]), connectionString);
                        selectedConversationIsGroup = true;
                    }
                    else 
                    {
                        CreateOrRemakeGroupMembersView();
                        groupMembersView.ClearListOfUsersInGroup();
                        groupMembersView.Text = reader[13].ToString() + " - not a group.";
                        selectedConversationIsGroup = false;
                    }

                    selectedConversationPk = Convert.ToInt32(reader[0]);

                    result = reader[13].ToString() + "\r\n"   // Partner Name
                            + reader[0].ToString() + "\r\n"    // ?
                            + reader[1].ToString() + "\r\n"   // ?
                            + reader[2].ToString() + "\r\n"   // ?
                            + reader[3].ToString() + "\r\n"   // Contact ID (0 for group)
                            + reader[7].ToString() + "\r\n"   // Group Info - empty if contact

                            + reader[4].ToString() + "\r\n"   // Deleted
                            + reader[5].ToString() + "\r\n"   // Number of messages
                            + reader[6].ToString() + "\r\n"   // Number of unread messages
                            
                            + reader[9].ToString() + "\r\n"   // Properties
                            + "\r\n"
                        //+ reader[10].ToString() + "\r\n"    // Last Message Date
                            + reader[11].ToString() + "\r\n"   // Contact Jabber ID
                            + reader[12].ToString() + "\r\n"   // Last Message Text
                            + reader[14].ToString() + "\r\n\r\n"        // Saved input
                            + getLastMessage.ZPUSHNAME + "\r\n"   // Last Message
                            + getLastMessage.ZISFROMME + "\r\n"   // Last Message
                            + getLastMessage.ZTEXT;   // Last Message
                }
                reader.Close();

                txtDetailDescription.Text = result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while opening database: " + ex.Message);
                
            }



        }

        private void loadWhatsAppDatabaseLocallyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string fileNameToLoad = "";// = "C:\\Users\\JG\\Downloads\\WhatForensics\\ChatStorage.sqlite";
            using (OpenFileDialog ofd = new OpenFileDialog()) 
            {
                ofd.Title = "Select WhatsApp Database";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    fileNameToLoad = ofd.FileName;
                    //connectionString = connectionString.Replace("%", fileNameToLoad);
                    LoadDatabase(fileNameToLoad);
                }
                //else 
                //{
                    // remember to uncomment on release!
                    // return;

                    // DEBUG ONLY
                    //connectionString = connectionString.Replace("%", fileNameToLoad);
                //}

            }

        }

        public void LoadDatabase(string fileNameToLoad) 
        {
            connectionString = "Data Source=%;Version=3;Read Only=True;".Replace("%", fileNameToLoad);
            MiscHelper.currentlyOpenFilePath = fileNameToLoad;
            //MessageBox.Show(fileNameToLoad);
            this.Text = "WhatForensics - " + fileNameToLoad;

            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand("select zpartnername, zgroupinfo from zwachatsession order by zlastmessagedate desc", connection);

            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                lbConversationList.Items.Clear();
                while (reader.Read())
                {

                    int index = lbConversationList.Items.Add(reader[0].ToString());

                }
                reader.Close();

                isDatabaseLoaded = true;
                viewToolStripMenuItem.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while opening database: " + ex.Message);
            }


            //WAGroupMember testMember = new WAGroupMember(1, connectionString);
            //MessageBox.Show(testMember.ZCONTACTNAME);
            
        }



        private void groupMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CreateOrRemakeGroupMembersView();
            groupMembersView.Hide();
            groupMembersView.Show();

        }

        private void CreateOrRemakeGroupMembersView() 
        {
            if (groupMembersView == null || groupMembersView.IsDisposed)
            {
                groupMembersView = new GroupMembersView();
                groupMembersView.Text = "Group Members";
            }
        }

        private void lbConversationList_DoubleClick(object sender, EventArgs e)
        {
            if (lbConversationList.SelectedIndex == -1) 
            {
                return;
            }
            MessageView messageView = new MessageView();
            messageView.Text = lbConversationList.SelectedItem.ToString();



            if (selectedConversationIsGroup)
            {
                messageView.IsGroupMessage = true;
            }
            else 
            {
                messageView.IsGroupMessage = false;
            }
            messageView.InitializeMessages(selectedConversationPk, connectionString);
            messageView.Show();
        }

        private void acquireWhatsAppDatabaseFromIOSDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcquisitionViaManzanaView acquisitionViaManzanaView = new AcquisitionViaManzanaView();
            acquisitionViaManzanaView.ownerPointer = this;
            acquisitionViaManzanaView.Show();

        }

        private void acquireWhatsAppDBFromITunesDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcquisitionViaItunesBackupView acquisitionViaItunesBackup = new AcquisitionViaItunesBackupView();
            acquisitionViaItunesBackup.ownerPointer = this;
            acquisitionViaItunesBackup.Show();
        }

        private void exitWhatForensicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wABlacklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //select zjid from zwablacklistitem

            string blacklistedIndividuals = "";

            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand("select zjid from zwablacklistitem", connection);

            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    blacklistedIndividuals += reader[0].ToString() + "\r\n";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while opening database: " + ex.Message);
            }

            MessageBox.Show(blacklistedIndividuals, "Blacklisted individuals");

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSettingsView thePage = new SearchSettingsView();
            thePage.connectionString = connectionString;
            thePage.Show();
        }

        private void knownIssuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("May crash when loading some versions of WA database due to db structure differences (on a brighter note, WA users are usually on the most recent version as older versions cannot connect to the servers)\r\n\r\nManzana library is unstable, sometimes crashes on starting acquisition.", "Known Issues");
        }

        private void aboutWhatForensicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutView about = new AboutView();
            about.Show();
        }
    }
}
