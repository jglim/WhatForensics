using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;


namespace WhatForensics
{
    class WAGroupMember
    {
        public bool GroupMemberLoaded = false;
        public int 
            Z_PK,
            Z_ENT,
            Z_OPT,
            ZCONTACTABID,
            ZISACTIVE,
            ZCHATSESSION,
            ZRECENTGROUPCHAT;
        public string 
            ZCONTACTNAME,
            ZMEMBERJID;

        public WAGroupMember(int GroupMemberPrimaryKey, string connectionString) 
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand("select * from zwagroupmember where z_pk = " + GroupMemberPrimaryKey.ToString() + " limit 1 offset 0", connection);

            connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Z_PK = Convert.ToInt32(reader[0]);
                Z_ENT = Convert.ToInt32(reader[1]);
                Z_OPT = Convert.ToInt32(reader[2]);
                ZCONTACTABID = Convert.ToInt32(reader[3]);
                ZISACTIVE = Convert.ToInt32(reader[4]);
                ZCHATSESSION = Convert.ToInt32(reader[5]);
                //ZRECENTGROUPCHAT = Convert.ToInt32(reader[6]);

                ZCONTACTNAME = reader[7].ToString();
                ZMEMBERJID = reader[8].ToString();

            }
            reader.Close();
            GroupMemberLoaded = true;
        
        }
    }
}
