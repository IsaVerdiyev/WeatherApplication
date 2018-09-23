using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Model;

namespace WeatherApplication.Services.StorageService
{
    interface IStorage
    {
        Dictionary<string, TotalInfoAboutWeatherOfCity> CityWeathers { get; set; }
    }
}
