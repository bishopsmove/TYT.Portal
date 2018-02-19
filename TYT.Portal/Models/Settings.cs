using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;



namespace TYT.Portal.Models
{
    public class Settings : ISettings
    {
        // TODO: Add workflow for rating app (notification or modal based)
        const string _useRoamSettingsKey = "use-roam-settings";
        const string _themeKey = "Theme";
        const string _notifyOnAppEventsKey = "notify-on-app-events";
        const string _downloadOnWifiOnly = "download-on-wifi-only";
        const string _downloadOnlyWhenAC_Connected = "download-only-when-ac-connected";
        const string _streamIfNotLocal = "stream-if-not-local";
        const string _powerPlayKey = "power-play-key";

        private readonly ApplicationDataContainer _container;

        public Settings(ApplicationDataContainer container)
        {
            _container = container;
        }

        public string Theme { get => GetValue<string>(_themeKey, "Dark"); 
            set
            {
                if (value != null && (value.Equals("Light", StringComparison.OrdinalIgnoreCase) || value.Equals("Dark", StringComparison.OrdinalIgnoreCase)))
                {
                    SetValue(_themeKey, value);
    }
                else
                {
                    Debug.Assert(false);
                }
            }}
        public bool UseRoamSettings {get => GetValue<bool>(_useRoamSettingsKey, false); set => SetValue(_useRoamSettingsKey, value); }
        public bool NotifyOnAppEvents { get => GetValue<bool>(_notifyOnAppEventsKey, true); set => SetValue(_notifyOnAppEventsKey, value); }
        public bool DownloadOnWifiOnly { get => GetValue<bool>(_downloadOnWifiOnly, false); set => SetValue(_downloadOnWifiOnly, value); }
        public bool DownloadOnlyWhenAC_Connected { get => GetValue<bool>(_downloadOnlyWhenAC_Connected, false); set => SetValue(_downloadOnlyWhenAC_Connected, value); }
        public bool StreamIfNotLocal { get => GetValue<bool>(_streamIfNotLocal, true); set => SetValue(_streamIfNotLocal, value); }
        public string PowerPressKey { get => GetValue<string>(_powerPlayKey, string.Empty); set => SetValue(_powerPlayKey, value); }

        public T GetValue<T>(string key, T defaultValue)
        {
            try
            {
                if (_container.Values.ContainsKey(key))
                {
                    return (T)_container.Values[key];
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error deserializing setting {key} - {e.Message}");
            }
            return defaultValue;
        }

        public void SetValue(string key, object value)
        {
            
            _container.Values[key] = value;
        }
    }
}
