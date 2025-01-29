using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace sdPlugin.Core
{
    public class PluginConfig
    {
        private readonly string _filePath;
        private Dictionary<string, object> _configValues = new Dictionary<string, object>();

        public PluginConfig(string pluginPath)
        {
            _filePath = Path.Combine(pluginPath, "config.json");

            if (!Directory.Exists(pluginPath))
                Directory.CreateDirectory(pluginPath);

            if (!File.Exists(_filePath))
            {
                _configValues = new Dictionary<string, object>();
                Save();
            }

            LoadConfig();
        }

        private void LoadConfig()
        {
            try
            {
                string json = File.ReadAllText(_filePath);
                _configValues = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            }
            catch
            {
                _configValues = new Dictionary<string, object>();
            }
        }

        public T Get<T>(string key)
        {
            LoadConfig();

            if (_configValues.TryGetValue(key, out var value))
            {
                try
                {
                    return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(value));
                }
                catch
                {
                    return default;
                }
            }
            return default;
        }

        public void Set<T>(string key, T value)
        {
            LoadConfig();

            _configValues[key] = value;
            Save();
        }

        private void Save()
        {
            try
            {
                string json = JsonConvert.SerializeObject(_configValues, Formatting.Indented);
                File.WriteAllText(_filePath, json);
            }
            catch { }
        }
    }
}
