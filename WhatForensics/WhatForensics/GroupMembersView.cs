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
    public partial class GroupMembersView : Form
    {
        public GroupMembersView()
        {
            InitializeComponent();
        }

        public void DrawListOfUsersInGroup(int userPrimaryKey, string connectionString)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand("select zcontactname from zwagroupmember where zchatsession = " + userPrimaryKey.ToString(), connection);


                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lbGroupMembers.Items.Add(reader[0].ToString());
                }
                reader.Close();


        }

        public void ClearListOfUsersInGroup() 
        {
            lbGroupMembers.Items.Clear();
        }

    }
}
