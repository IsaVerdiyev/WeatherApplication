using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Model;

namespace WeatherApplication.Presenter
{
    interface IMainInfoPresenter
    {
        Dictionary<string, TotalInfoAboutWeatherOfCity> CityWeathers { get; set; }
        Task AddCity(string city);
        void RemoveCity(string city);
        void UpdateInfoOfSelectedCity(string city);
    }
}
