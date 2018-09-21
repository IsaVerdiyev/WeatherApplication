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
        GraphUserControl hourlyGraph;
        public MainInfoView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            mainInfoPresenter = new MainInfoPresenter(this, new OpenWeatherMapWeatherInfoGetter("d03069ad008b108f3f6e60663a3587f1"));
            hourlyGraph = new GraphUserControl();
            HourlyColumnTableLayoutPanel.Controls.Add(hourlyGraph);
        }

        public CancellationToken Cancelation { get; private set; }

        public void UpdateInfoViewAboutWeather()
        {
            string selectedCity = CitiesComboBox.SelectedItem as string;
            if (selectedCity != null)
            {
                CityNameLabel.Text = CitiesComboBox.SelectedItem as string;
                DegreeLabel.Text = mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.Temperature.ToString() + "°C";
                DescriptionLabel.Text = mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.Description;
                LastUpdateTimeLabel.Text = $"Last update time {mainInfoPresenter.CityWeathers[selectedCity].LastUpdateTime.ToShortTimeString()}";
                PressureLabel.Text = $"Pressure {mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.Pressure} hPa";
                HumidityLabel.Text = $"Humidity {mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.Humidity} %";
                WindLabel.Text = $"Wind {mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.WindSpeed} m/s";
                UpdateDailyWeatherColumn();
                UpdateHourlyColumn(mainInfoPresenter.CityWeathers[CitiesComboBox.SelectedItem as string].CurrentWeather.Date.Date);
            }
        }

        void UpdateDailyWeatherColumn()
        {
            var dailyWeathers = (from weather in mainInfoPresenter.CityWeathers[CitiesComboBox.SelectedItem as string].ForecastListOfWeathers
                                 group weather by weather.Date.Date into weathersOfDay
                                 orderby weathersOfDay.Key
                                 let maxTemp = weathersOfDay.Max(x => x.MaxTemperature)
                                 let minTemp = weathersOfDay.Min(x => x.MinTemperature)
                                 select new Weather
                                 {
                                     Date = weathersOfDay.Key,
                                     MinTemperature = minTemp,
                                     MaxTemperature = maxTemp
                                 }).ToList<Weather>();

            DailyWeatherInfoTableLayoutPanel.Controls.Clear();
            DailyWeatherInfoTableLayoutPanel.ColumnCount = 0;
            DailyWeatherInfoTableLayoutPanel.ColumnStyles.Clear();
            
            for (int i = 0; i < dailyWeathers.Count; i++)
            {
                DailyItemUserControl dailyItemUserControl = new DailyItemUserControl();
                dailyItemUserControl.DateLabel.Text = $"{dailyWeathers[i].Date.Day}, {dailyWeathers[i].Date.DayOfWeek.ToString()}";
                dailyItemUserControl.TemperatureLabel.Text = $"{dailyWeathers[i].MaxTemperature}   {dailyWeathers[i].MinTemperature}";
                DailyWeatherInfoTableLayoutPanel.ColumnCount++;
                DailyWeatherInfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                DailyWeatherInfoTableLayoutPanel.Controls.Add(dailyItemUserControl, i, 0);
            }
        }

        void UpdateHourlyColumn(DateTime date)
        {
            List<Weather> hourlyWeathersForSelectedDay = mainInfoPresenter.CityWeathers[CitiesComboBox.SelectedItem as string].ForecastListOfWeathers.Where(w => w.Date.Date == date.Date).ToList<Weather>();
            ((IHourlyUpdate)HourlyColumnTableLayoutPanel.Controls[1]).UpdateHourly(hourlyWeathersForSelectedDay);

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
            var ta = mainInfoPresenter.AddCity(NewCityTextBox.Text).ContinueWith(t =>
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
                   MessageBox.Show("City wasn't found");
               }
               catch (WebException ex)
               {
                   MessageBox.Show("There is no internet. Check internet connection");
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message, "caption", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }
           }, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.FromCurrentSynchronizationContext());

            //try
            //{

            //    await ta;
            //} catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}
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
