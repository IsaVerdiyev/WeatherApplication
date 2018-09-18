﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Exceptions;
using WeatherApplication.Model;
using WeatherApplication.Services;
using WeatherApplication.Services.WeatherInfoGetter;
using WeatherApplication.View;

namespace WeatherApplication.Presenter
{
    class MainInfoPresenter: IMainInfoPresenter
    {
        IMainInfoView mainInfoView;

        IWeatherInfoGetter weatherInfoGetter;

        Dictionary<string, TotalInfoAboutWeatherOfCity> cityWeathers;

        public MainInfoPresenter(IMainInfoView mainInfoView, IWeatherInfoGetter weatherInfoGetter)
        {
            this.mainInfoView = mainInfoView;
            this.weatherInfoGetter = weatherInfoGetter;
            CityWeathers = new Dictionary<string, TotalInfoAboutWeatherOfCity>();
        }

        public Dictionary<string, TotalInfoAboutWeatherOfCity> CityWeathers { get => cityWeathers; set => cityWeathers = value; }

        public async void AddCity(string city)
        {
            if (CityWeathers.ContainsKey(city))
            {
                throw new CityAlreadyIsInList();
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
            mainInfoView.UpdateInfoAboutWeather();
            //foreach (var city in cityWeathers)
            //{
            //    Task<Weather> currentWeather = weatherInfoGetter.GetCurrentWeatherOfCityAsync(city.Key);
            //    Task<List<Weather>> forecastWeathers = weatherInfoGetter.GetForecastWeathersOfCityAsync(city.Key);
            //    await Task.Run(() =>
            //    {
            //        CityWeathers[city.Key].CurrentWeather = currentWeather.Result;
            //        CityWeathers[city.Key].ForecastListOfWeathers = forecastWeathers.Result;
            //        CityWeathers[city.Key].LastUpdateTime = DateTime.Now;
            //        mainInfoView.UpdateListOfCitites(city.Key);
            //    });
            //}
        }
    }
}
