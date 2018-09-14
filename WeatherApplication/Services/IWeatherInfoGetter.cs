using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Model;

namespace WeatherApplication.Services
{
    interface IWeatherInfoGetter
    {
        List<Weather> GetWeathersOfCity(string city);
        Task<List<Weather>> GetWeathersOfCityAsync(string city);
    }
}
