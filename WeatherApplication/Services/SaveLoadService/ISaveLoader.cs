using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Model;

namespace WeatherApplication.Services.SaveLoadService
{
    interface ISaveLoader
    {
        void Save(Tuple<Dictionary<string, TotalInfoAboutWeatherOfCity>, string> tupleOfDictionaryAndSelectedIndex);
        Task SaveAsync(Tuple<Dictionary<string, TotalInfoAboutWeatherOfCity>, string> tupleOfDictionaryAndSelectedIndex);
        Tuple<Dictionary<string, TotalInfoAboutWeatherOfCity>, string> Load();
        Task<Tuple<Dictionary<string, TotalInfoAboutWeatherOfCity>, string>> LoadAsync();
        string SaveFilePath { get; }
    }
}
