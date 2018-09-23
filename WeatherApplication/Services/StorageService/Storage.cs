using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Model;

namespace WeatherApplication.Services.StorageService
{
    class Storage : IStorage
    {
        Dictionary<string, TotalInfoAboutWeatherOfCity> cityWeathers;

        public Dictionary<string, TotalInfoAboutWeatherOfCity> CityWeathers { get => cityWeathers; set => cityWeathers = value; }

        static IStorage storage;

        private Storage()
        {
            CityWeathers = new Dictionary<string, TotalInfoAboutWeatherOfCity>();
        }

        public static IStorage StorageInstance { get => storage ?? (storage = new Storage()); }


    }
}
