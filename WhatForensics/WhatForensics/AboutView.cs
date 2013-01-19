using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace WhatForensics
{
    public partial class AboutView : Form
    {
        /*
         * 
         * Hello DF (NP/ICT)! 
         * -jg
         * 
         */

        public AboutView()
        {
            InitializeComponent();
        }

        private void AboutView_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;


            txtAbout.Text = txtAbout.Text.Replace("%assemblyVersion%", "-").Replace("%fileVersion%", version);
        }
    }
}
