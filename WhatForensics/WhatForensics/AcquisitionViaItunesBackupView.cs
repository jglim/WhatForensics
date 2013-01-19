using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace WhatForensics
{
    public partial class AcquisitionViaItunesBackupView : Form
    {
        public AcquisitionViaItunesBackupView()
        {
            InitializeComponent();
        }


        string manualInfoFilePath = "";
        public MainMenu ownerPointer;

        private void AcquisitionViaItunesBackup_Load(object sender, EventArgs e)
        {
            loadBackupsFromiTunesFolder();


        }

        private void LoadInfoPlist(string individualBackupFolder) 
        {
            txtDescriptionData.Text = "";
            txtDescription.Text = "";

            if (System.IO.File.Exists(individualBackupFolder + "\\Info.plist"))
            {
                //MessageBox.Show("Exists");
                XmlDocument doc = new XmlDocument();
                doc.Load(individualBackupFolder + "\\Info.plist");

                XmlNodeList keyList = doc.GetElementsByTagName("key");
                for (int i = 0; i < 14; i++)
                {
                    txtDescription.Text = txtDescription.Text + "\r\n" + (keyList[i].InnerText);
                    txtDescriptionData.Text = txtDescriptionData.Text + "\r\n" + keyList[i].NextSibling.InnerText;
                }


            }

            //MessageBox.Show(cbBackupList.Text + "\\Info.plist");
            
        }

        private void LoadSqlite(string mbdbLocation) 
        {
            if (mbdbLocation.Length == 0) 
            {
                return; // cannot be 0
            }

            string whatsAppSqliteLocation = "";
            List<WhatForensics.mbdb.MBFileRecord> mbdbRecords = WhatForensics.mbdb.ReadMBDB(mbdbLocation);
            foreach (WhatForensics.mbdb.MBFileRecord mbdbRecord in mbdbRecords)
            {
                if (mbdbRecord.Domain == "AppDomain-net.whatsapp.WhatsApp")
                {
                    if (mbdbRecord.Path == "Documents/ChatStorage.sqlite")
                    {
                        whatsAppSqliteLocation = mbdbLocation + "\\" + mbdbRecord.key;
                    }


                }
            }

            if (whatsAppSqliteLocation.Length == 0) 
            {
                MessageBox.Show("WhatsApp was not found on this backup file", "WhatsApp not found", MessageBoxButtons.OK);
            }

            ownerPointer.LoadDatabase(whatsAppSqliteLocation);
        }

        private void loadBackupsFromiTunesFolder() 
        {
            string iTunesBackupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Apple Computer\\MobileSync\\Backup\\";
            if (System.IO.Directory.Exists(iTunesBackupFolderPath))
            {
                string[] directories = System.IO.Directory.GetDirectories(iTunesBackupFolderPath);
                cbBackupList.Items.Clear();
                foreach (string directory in directories)
                {
                    cbBackupList.Items.Add(directory);
                }
            }
        }

        private void chkUseMachineBackups_CheckedChanged(object sender, EventArgs e)
        {
            btnBrowse.Enabled = !chkUseMachineBackups.Checked;
            cbBackupList.Enabled = chkUseMachineBackups.Checked;
            if (chkUseMachineBackups.Enabled) 
            {
                loadBackupsFromiTunesFolder();
            }
            

        }

        private void btnAcquire_Click(object sender, EventArgs e)
        {
            if (chkUseMachineBackups.Checked)
            {
                LoadSqlite(cbBackupList.Text);
            }
            else 
            {
                LoadSqlite(manualInfoFilePath);
            }
            
            
            MessageBox.Show("Acquisition Complete");
            this.Close();
        }

        private void cbBackupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInfoPlist(cbBackupList.Text);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select folder to load backup from";
            ofd.Multiselect = false;
            ofd.Filter = "Backup information file (Info.plist)|";

            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                manualInfoFilePath = ofd.FileName.Remove(ofd.FileName.Length - "Info.plist".Length);
                
            }

            LoadInfoPlist(manualInfoFilePath);
        }
    }
}
