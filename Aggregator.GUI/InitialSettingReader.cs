using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Aggregator.Core;
using Aggregator.GUI.Properties;

namespace Aggregator.GUI
{
   public static  class InitialSettingReader
    {
       public static bool FullModeRSS()
       {
            bool aggregatorPerUser = Aggregator.GUI.Properties.Settings.Default.StorePerUser;
            AppSettings settings =  AppSettings.LoadSettings(aggregatorPerUser, false);
           return settings.AppOutlookSettings.LaunchOutlookReaderOnStartup; 
       }
    }
}
