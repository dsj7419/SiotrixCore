using Newtonsoft.Json;
using System;
using System.IO;

namespace Siotrix
{
    public class ConfigurationBase
    {
        [JsonIgnore]
        public static string FileName { get; private set; } = "config/configuration.json";
        public string Instance { get; set; } = "siotrix";
        public string Server { get; set; } = "localhost";
        public string Port { get; set; } = "3306";
        public string User { get; set; } = "root";
        public string Password { get; set; } = "";

        public ConfigurationBase() { }
        public ConfigurationBase(string fileName)
        {
            FileName = fileName;
        }

        public void SaveJson()
        {
            string file = Path.Combine(AppContext.BaseDirectory, FileName);
            File.WriteAllText(file, ToJson());
        }

        public static T Load<T>() where T : ConfigurationBase
        {
            string file = Path.Combine(AppContext.BaseDirectory, FileName);
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(file));
        }

        public string ToJson()
            => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
