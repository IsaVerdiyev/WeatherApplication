using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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
       
        IWeatherInfoGetter weatherInfoGetter;

        IMainView mainView;

        

        public MainInfoPresenter(IMainView mainView, IWeatherInfoGetter weatherInfoGetter)
        {
            this.mainView = mainView;
            this.weatherInfoGetter = weatherInfoGetter;
        }

        public Dictionary<string, TotalInfoAboutWeatherOfCity> CityWeathers {
            get => Storage.StorageInstance.CityWeathers;
            set
            {
                Storage.StorageInstance.CityWeathers = value;
                Storage.StorageInstance.SaveAsync();
            }
        }
        public string SelectedCity {
            get => Storage.StorageInstance.SelectedCity;
            set
            {
                Storage.StorageInstance.SelectedCity = value;
                Storage.StorageInstance.SaveAsync().ContinueWith(t =>
                {
                    try
                    {
                        throw t.Exception.InnerExceptions.FirstOrDefault();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                    }
                }, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        public string IconFolderPath => weatherInfoGetter.IconsFolderPath;

        public async Task AddCity(string city)
        {
            if (String.IsNullOrWhiteSpace(city))
            {
                throw new CityNameIsNullOrWhiteSpaceException();
            }
            city = char.ToUpper(city[0]) + city.Substring(1);
            if (CityWeathers.ContainsKey(city))
            {
                throw new CityAlreadyIsInListException(city);
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

            SelectedCity = city;

            mainView.UpdateCitiesView();
            mainView.UpdateWeatherInfoView();
        }

        public void LoadStorageFromSaveIfExist()
        {
            if (File.Exists(Storage.StorageInstance.SaveFilePath))
            {
                Storage.StorageInstance.Load();
            }
        }

        public async Task LoadStorageFromSaveIfExistAsync()
        {
            if (File.Exists(Storage.StorageInstance.SaveFilePath))
            {
                await Storage.StorageInstance.LoadAsync();
            }
        }

        public void RemoveCity(string city)
        {
            CityWeathers.Remove(city);
            if (!CityWeathers.Keys.Contains(city))
            {
                SelectedCity = CityWeathers.Keys.FirstOrDefault();
            }
            mainView.UpdateCitiesView();
            mainView.UpdateWeatherInfoView();
        }

        public void UpdateInfoOfSelectedCity(string city)
        {
            LoadFromNetUpdatedInfoAboutCity(city);
            mainView.UpdateWeatherInfoView();
        }

        public async Task UpdateInfoOfSelectedCityAsync(string city)
        {
            await LoadFromNetUpdatedInfoAboutCityAsync(city);
            mainView.UpdateWeatherInfoView();
        }

        public void LoadFromNetUpdatedInfoAboutCity(string city)
        {
            Weather currentWeather = weatherInfoGetter.GetCurrentWeatherOfCity(city);
            List<Weather> forecastWeathers = weatherInfoGetter.GetForecastWeathersOfCity(city);

            CityWeathers[city].CurrentWeather = currentWeather;
            CityWeathers[city].ForecastListOfWeathers = forecastWeathers;
            CityWeathers[city].LastUpdateTime = DateTime.Now;
        }

        public async Task LoadFromNetUpdatedInfoAboutCityAsync(string city)
        {
            Task<Weather> currentWeather = weatherInfoGetter.GetCurrentWeatherOfCityAsync(city);
            Task<List<Weather>> forecastWeathers = weatherInfoGetter.GetForecastWeathersOfCityAsync(city);

            CityWeathers[city].CurrentWeather = await currentWeather;
            CityWeathers[city].ForecastListOfWeathers = await forecastWeathers;
            CityWeathers[city].LastUpdateTime = DateTime.Now;
        }
    }
}
