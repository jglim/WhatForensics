using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manzana;


namespace WhatForensics
{
    public partial class AcquisitionViaManzanaView : Form
    {
        public iPhone testDevice = new iPhone();
        public MainMenu ownerPointer;


        public AcquisitionViaManzanaView()
        {
            InitializeComponent();
        }

        private void AcquisitionViaManzanaView_Load(object sender, EventArgs e)
        {
            this.Text = "Automated Database Acquisition - " + testDevice.DeviceName;

            string phoneDetails = "";
            phoneDetails = phoneDetails +
                testDevice.DeviceName + "\r\n" +
                testDevice.DevicePhoneNumber + "\r\n" +
                testDevice.DeviceSerialNumber + "\r\n" +
                testDevice.DeviceSIMStatus + "\r\n" +
                testDevice.DeviceTimeZone + "\r\n" +
                testDevice.DeviceType + "\r\n" +
                testDevice.DeviceVersion + "\r\n" +
                testDevice.DeviceWiFiAddress + "\r\n" +
                testDevice.DeviceActivationState + "\r\n" +
                testDevice.DeviceBaseband + "\r\n" +
                testDevice.DeviceColor + "\r\n" +
                testDevice.DeviceId + "\r\n" +
                testDevice.IsIphone;

            txtDeviceDescription.Text = phoneDetails;

        }



        private void btnAcquire_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Warning: This mode of acquisition may not be forensically safe as it uses utilities (AFC) only available on jailbroken devices. This means that the derived data may not be accepted in court. Are you sure you want to continue?", "Warning", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel) 
            {
                return;
            }

            string waSandboxedPath = "";
            string[] paths = testDevice.GetDirectories("/var/mobile/Applications/");
            pbAcquisition.Maximum = paths.Length;
            int progress = 0;
            foreach (string appSandboxFolders in paths) 
            {
                progress++;
                pbAcquisition.Value = progress;
                Application.DoEvents();

                string[] subfolders = testDevice.GetDirectories("/var/mobile/Applications/" + appSandboxFolders + "/");
                foreach (string appFolders in subfolders) 
                {
                    if (appFolders == "WhatsApp.app") 
                    {
                        waSandboxedPath = "/var/mobile/Applications/" + appSandboxFolders + "/Documents/ChatStorage.sqlite";
                    }
                }
            }


            //bool success = testDevice.Exists(waSandboxedPath);
            //MessageBox.Show(waSandboxedPath);
            string copyDestination = Application.StartupPath + "\\AcquiredChatStorage.sqlite";
            if (System.IO.File.Exists(copyDestination)) 
            {
                System.IO.File.Delete(copyDestination);
            }
            bool success = testDevice.CopyFileFromPhone(testDevice, waSandboxedPath, Application.StartupPath, "AcquiredChatStorage.sqlite");

            //MessageBox.Show(copyDestination);

            ownerPointer.LoadDatabase(copyDestination);

            MessageBox.Show("Acquisition Complete");
            this.Close();
            //MessageBox.Show(success.ToString());
        }
    }
}
