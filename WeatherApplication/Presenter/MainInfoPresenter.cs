using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Exceptions;
using WeatherApplication.Model;
using WeatherApplication.Services;
using WeatherApplication.Services.StorageService;
using WeatherApplication.Services.WeatherInfoGetter;
using WeatherApplication.View;

namespace WeatherApplication.Presenter
{
    class MainInfoPresenter: IMainInfoPresenter
    {
        IMainInfoView mainInfoView;

        IWeatherInfoGetter weatherInfoGetter;

        

        public MainInfoPresenter(IMainInfoView mainInfoView, IWeatherInfoGetter weatherInfoGetter)
        {
            this.mainInfoView = mainInfoView;
            this.weatherInfoGetter = weatherInfoGetter;
           
        }

        public Dictionary<string, TotalInfoAboutWeatherOfCity> CityWeathers { get => Storage.StorageInstance.CityWeathers; set => Storage.StorageInstance.CityWeathers = value; }

        public async Task AddCity(string city)
        {
            if (String.IsNullOrWhiteSpace(city))
            {
                throw new CityNameIsNullOrWhiteSpaceException();
            }
            if (CityWeathers.ContainsKey(city))
            {
                throw new CityAlreadyIsInListException();
            }

            Weather currentWeatherOfCity = weatherInfoGetter.GetCurrentWeatherOfCity(city);

            CityWeathers.Add(city, null);

            List<Weather> forecastWeathers = await weatherInfoGetter.GetForecastWeathersOfCityAsync(city);
            CityWeathers[city] = new TotalInfoAboutWeatherOfCity
            {
                CurrentWeather = currentWeatherOfCity,
                ForecastListOfWeathers = forecastWeathers,
                LastUpdateTime = DateTime.Now
            };

            mainInfoView.UpdateListOfCitites(city);
        }

        public void RemoveCity(string city)
        {
            CityWeathers.Remove(city);
            mainInfoView.UpdateListOfCitites(city);
        }

        public async void UpdateInfoOfSelectedCity(string city)
        {
            Task<Weather> currentWeather = weatherInfoGetter.GetCurrentWeatherOfCityAsync(city);
            Task<List<Weather>> forecastWeathers = weatherInfoGetter.GetForecastWeathersOfCityAsync(city);

            CityWeathers[city].CurrentWeather = await currentWeather;
            CityWeathers[city].ForecastListOfWeathers = await forecastWeathers;
            CityWeathers[city].LastUpdateTime = DateTime.Now;
            mainInfoView.UpdateInfoViewAboutWeather();
        }
    }
}
