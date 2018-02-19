using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYT.Portal.Models
{
    public interface ISettings
    {
        string Theme { get; set; }
        bool UseRoamSettings { get; set; }
        bool NotifyOnAppEvents { get; set; }
        bool DownloadOnWifiOnly { get; set; }
        bool DownloadOnlyWhenAC_Connected { get; set; }
        bool StreamIfNotLocal { get; set; }
        string PowerPressKey { get; set; }

        T GetValue<T>(string key, T defaultValue);

        void SetValue(string key, object value);
    }
}
