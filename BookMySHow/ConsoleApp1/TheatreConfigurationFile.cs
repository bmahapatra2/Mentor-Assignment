using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace AppSettings
{
    public class TheatreConfigurationFile
    {
        public static List<string> ShowConfig()
        {
          //List<> TheatreProviderList = new List<ConfigurationManager>();
          // For read access you do not need to call OpenExeConfiguraton
          List<string> values = new List<string>();
          foreach (string key in ConfigurationManager.AppSettings)
          {
              values.Add(ConfigurationManager.AppSettings[key]);
              Console.WriteLine("Key: {0}, Value: {1}", key, (ConfigurationManager.AppSettings[key]));
          }
          return values;
        }
        //string path = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
        static void Main(string[] args)
        {
//
// ShowConfig();
//
// // Open App.Config of executable
// Configuration config = ConfigurationManager.OpenExeConfiguration
//              (ConfigurationUserLevel.None);
//
// // Add an Application Setting.
// if (config.AppSettings.Settings.Count == 0)
// {
//     config.AppSettings.Settings.Add("1", "DCTheatreProvider");
//     config.AppSettings.Settings.Add("2", "MarvelsTheatreProvider");
// }
// // Save the changes in App.config file.
// config.Save(ConfigurationSaveMode.Modified);
//
// // Force a reload of a changed section.
// ConfigurationManager.RefreshSection("appSettings");
// //string path = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
// //  Console.WriteLine(path);
// //ShowConfig();
// Console.Read();
        }
    }
}
