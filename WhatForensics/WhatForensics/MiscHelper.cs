using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatForensics
{
    class MiscHelper
    {
        public static string HandleWeirdEpoch(string sqlite_date_string) 
        {
            int year = Convert.ToInt32(sqlite_date_string.Remove(4)) + 31;
            return year.ToString() + sqlite_date_string.Remove(0, 4);

           
        }
        
        public static string HandleWeirdEpochAddTimezoneInformation(string sqlite_date_string)
        {
            int year = Convert.ToInt32(sqlite_date_string.Remove(4)) + 31;
            return year.ToString() + sqlite_date_string.Remove(0, 4) + " " + TimeZone.CurrentTimeZone.StandardName;


        }

        public static string currentlyOpenFilePath = "";
        public static string investigatorName = "Investigator Name";

    }
}
