using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WeatherApplication.Model;
using WeatherApplication.Services.StorageService;

namespace WeatherApplication.Services.SaveLoadService
{
    class JsonSaveLoader : ISaveLoader
    {
        readonly string savePath;

        object lockObject = new object();

        public JsonSaveLoader(string savePath)
        {
            this.savePath = savePath;
        }

        public string SaveFilePath => savePath;

        public Tuple<Dictionary<string, TotalInfoAboutWeatherOfCity>, string> Load()
        {
            return JsonConvert.DeserializeObject<Tuple<Dictionary<string, TotalInfoAboutWeatherOfCity>, string>>(File.ReadAllText(savePath));
        }

        public async Task<Tuple<Dictionary<string, TotalInfoAboutWeatherOfCity>, string>> LoadAsync()
        {
            string jsonText;
            using (StreamReader reader = new StreamReader(savePath))
            {
                jsonText = await reader.ReadToEndAsync();
            }

            return JsonConvert.DeserializeObject<Tuple<Dictionary<string, TotalInfoAboutWeatherOfCity>, string>>(jsonText);
        }

        public void Save(Tuple<Dictionary<string, TotalInfoAboutWeatherOfCity>, string> tupleOfDictionaryAndSelectedIndex)
        {
            File.WriteAllText(savePath, JsonConvert.SerializeObject(tupleOfDictionaryAndSelectedIndex));
        }

        public async Task SaveAsync(Tuple<Dictionary<string, TotalInfoAboutWeatherOfCity>, string> tupleOfDictionaryAndSelectedIndex)
        {
            Monitor.Enter(lockObject);
            using(StreamWriter writer = new StreamWriter(savePath))
            {
                await writer.WriteLineAsync(JsonConvert.SerializeObject(tupleOfDictionaryAndSelectedIndex));
            }
            Monitor.Exit(lockObject);
        }
    }
}
