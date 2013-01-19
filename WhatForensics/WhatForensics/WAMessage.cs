using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;


namespace WhatForensics
{
    class WAMessage
    {

        public int 
            Z_PK,
            Z_ENT,
            Z_OPT,
            Z_GROUPEVENTTYPE,
            ZISFROMME,
            ZMESSAGESTATUS,
            ZMESSAGETYPE,
            ZSORT,
            ZCHATSESSION,
            ZGROUPMEMBER,
            ZLASTSESSION;
        public string
            ZMEDIAITEM,
            //ZMESSAGEDATE,
            ZFROMJID,
            ZPUSHNAME,
            ZSTANZAID,
            ZTEXT,
            ZTOJID,
            ZMESSAGEDATE;



        public bool MessageLoaded = false;

        public WAMessage(int messagePrimaryKey, string connectionString) 
        { 
            
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand("select *, datetime(zmessagedate, 'unixepoch', 'localtime') from zwamessage where z_pk = " + messagePrimaryKey.ToString() + " limit 1 offset 0", connection);

            connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Z_PK = Convert.ToInt32(reader[0]);
                Z_ENT = Convert.ToInt32(reader[1]);
                Z_OPT = Convert.ToInt32(reader[2]);
                Z_GROUPEVENTTYPE = Convert.ToInt32(reader[3]);
                ZISFROMME = Convert.ToInt32(reader[4]);
                ZMESSAGESTATUS = Convert.ToInt32(reader[5]);
                ZMESSAGETYPE = Convert.ToInt32(reader[6]);
                ZSORT = Convert.ToInt32(reader[7]);
                ZCHATSESSION = Convert.ToInt32(reader[8]);

                if (!(reader[9] is DBNull))
                {
                    ZGROUPMEMBER = Convert.ToInt32(reader[9]);
                }

                //ZGROUPMEMBER = Convert.ToInt32(reader[9]);

                if (!(reader[10] is DBNull))
                {
                    ZLASTSESSION = Convert.ToInt32(reader[10]);
                }



                if (!(reader[11] is DBNull))
                {
                    ZMEDIAITEM = reader[11].ToString();
                }


                //ZMESSAGEDATE = reader[12].ToString(); // Fix date later


                //ZMESSAGEDATE = reader.GetDataTypeName(12);

                ZMESSAGEDATE = (reader[18].ToString());
                //System.Windows.Forms.MessageBox.Show(MiscHelper.HandleWeirdEpochAddTimezoneInformation(ZMESSAGEDATE));
                //System.Windows.Forms.MessageBox.Show(test.ToLongTimeString());


                //System.Windows.Forms.MessageBox.Show(reader[12].ToString());
                //ZMESSAGEDATE = new DateTime(Convert.ToInt64(reader[12]) );
                ZFROMJID = reader[13].ToString();

                if (!(reader[14] is DBNull))
                {
                    ZPUSHNAME = reader[14].ToString();
                }

                ZPUSHNAME = reader[14].ToString();
                ZSTANZAID = reader[15].ToString();
                ZTEXT = reader[16].ToString();
                ZTOJID = reader[17].ToString();
                    
            }
            reader.Close();
            MessageLoaded = true;

        
        
        }

    }
}
