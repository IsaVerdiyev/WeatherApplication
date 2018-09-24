using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Model;
using WeatherApplication.Services.SaveLoadService;

namespace WeatherApplication.Services.StorageService
{
    class Storage : IStorage
    {
        Dictionary<string, TotalInfoAboutWeatherOfCity> cityWeathers;

        string selectedCity = null;

        ISaveLoader saveLoader;

        public Dictionary<string, TotalInfoAboutWeatherOfCity> CityWeathers { get => cityWeathers; set => cityWeathers = value; }

        static IStorage storage;

        

        private Storage()
        {
            CityWeathers = new Dictionary<string, TotalInfoAboutWeatherOfCity>();
            saveLoader = new JsonSaveLoader("SaveFile.json");
        }

        public static IStorage StorageInstance { get => storage ?? (storage = new Storage()); }

        public string SelectedCity
        {
            get => selectedCity;
            set => selectedCity = value;
        }

        public string SaveFilePath => saveLoader.SaveFilePath;

        public void Save()
        {
            var saveTuple = new Tuple<Dictionary<string, TotalInfoAboutWeatherOfCity>, string>(CityWeathers, SelectedCity);
            saveLoader.Save(saveTuple);
        }

        public async Task SaveAsync()
        {
            var saveTuple = new Tuple<Dictionary<string, TotalInfoAboutWeatherOfCity>, string>(CityWeathers, SelectedCity);
            await saveLoader.SaveAsync(saveTuple);
        }

        public void Load()
        {
            var loadTuple = saveLoader.Load();
            CityWeathers = loadTuple.Item1;
            SelectedCity = CityWeathers.Keys.FirstOrDefault(k => k == loadTuple.Item2);
        }

        public async Task LoadAsync()
        {
            var loadTuple = await saveLoader.LoadAsync();
            CityWeathers = loadTuple.Item1;
            SelectedCity = CityWeathers.Keys.FirstOrDefault(k => k == loadTuple.Item2);
        }
    }
}
