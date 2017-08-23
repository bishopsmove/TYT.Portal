using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TYT.Portal.Helpers;

using TYT.Portal.Models;
using Windows.Storage;

namespace TYT.Portal.Services
{
    public static class SettingsService
    {
        private static readonly string settingsKey = "appSettings";
        

        public static ISettings Settings { get; set; }

        public static async Task InitializeAsync()
        {
            await Task.Run(() =>
            {
                Settings = new Settings(ApplicationData.Current.LocalSettings);


                if (Settings.UseRoamSettings && ApplicationData.Current.IsRoamingStorageAvailable())
                {
                    Settings = new Settings(ApplicationData.Current.RoamingSettings);
                }
            });
                
            
        }

        

        //public static async Task SaveSettingsAsync()
        //{
        //    if (Settings.UseRoamSettings && ApplicationData.Current.IsRoamingStorageAvailable())
        //    {
        //        await ApplicationData.Current.RoamingSettings.SaveAsync<ISettings>(settingsKey, Settings);
        //    }

        //    await ApplicationData.Current.LocalSettings.SaveAsync<ISettings>(settingsKey, Settings);
        //}

    }
}
