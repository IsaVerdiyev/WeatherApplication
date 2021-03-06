﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Model;

namespace WeatherApplication.Presenter
{
    public interface IMainInfoPresenter
    {
        Dictionary<string, TotalInfoAboutWeatherOfCity> CityWeathers { get; set; }
        String SelectedCity { get; set; }
        Task AddCity(string city);
        void RemoveCity(string city);
        void UpdateInfoOfSelectedCity(string city);
        Task UpdateInfoOfSelectedCityAsync(string city);
        void UpdateInfoOfAllCities();
        Task UpdateInfoOfAllCitiesAsync();
        string IconFolderPath { get; }
        void LoadStorageFromSaveIfExist();
        Task LoadStorageFromSaveIfExistAsync();
    }
}
