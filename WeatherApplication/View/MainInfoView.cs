using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApplication.Services;
using WeatherApplication.Model;
using WeatherApplication.Presenter;
using WeatherApplication.Services.WeatherInfoGetter;
using WeatherApplication.View.SubViews;
using WeatherApplication.Exceptions;
using WeatherApplication.Services.WeatherInfoGetter.Exceptions;
using System.Net;
using System.Threading;

namespace WeatherApplication.View
{
    public partial class MainInfoView : UserControl, IMainInfoView
    {
        IMainInfoPresenter mainInfoPresenter;
        public MainInfoView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            mainInfoPresenter = new MainInfoPresenter(this, new OpenWeatherMapWeatherInfoGetter("d03069ad008b108f3f6e60663a3587f1"));
            HourlyColumnTableLayoutPanel.Controls.Add(new GraphUserControl());
            
        }

        public CancellationToken Cancelation { get; private set; }

        public void UpdateInfoViewAboutWeather()
        {
            string selectedCity = CitiesComboBox.SelectedItem as string;
            if (selectedCity != null) {
                CityNameLabel.Text = CitiesComboBox.SelectedItem as string;
                DegreeLabel.Text = mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.Temperature.ToString() + "°C";
                DescriptionLabel.Text = mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.Description;
                LastUpdateTimeLabel.Text = $"Last update time {mainInfoPresenter.CityWeathers[selectedCity].LastUpdateTime.ToShortTimeString()}";
                PressureLabel.Text = $"Pressure {mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.Pressure} hPa";
                HumidityLabel.Text = $"Humidity {mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.Humidity} %";
                WindLabel.Text = $"Wind {mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.WindSpeed} m/s";
            }
        }

        public void UpdateListOfCitites(string city)
        {
            CitiesComboBox.DataSource = mainInfoPresenter.CityWeathers.Keys.ToList();
            CitiesComboBox.SelectedItem = city;
            NewCityTextBox.Text = "";
            UpdateInfoViewAboutWeather();
        }

        void AddCity()
        {

             mainInfoPresenter.AddCity(NewCityTextBox.Text).ContinueWith(t =>
            {
                try
                {
                    throw t.Exception.InnerExceptions.FirstOrDefault();
                }
                catch (CityAlreadyIsInListException ex)
                {
                    CitiesComboBox.SelectedItem = mainInfoPresenter.CityWeathers.Keys.FirstOrDefault(c => c == NewCityTextBox.Text);
                }
                catch (CityNameIsNullOrWhiteSpaceException ex)
                {

                }
                catch (CityNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (WebException ex)
                {
                    MessageBox.Show("There is no internet. Check internet connection");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "caption",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.FromCurrentSynchronizationContext());
            
        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            AddCity();
        }

        private void CitiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfoViewAboutWeather();
        }
    }
}
