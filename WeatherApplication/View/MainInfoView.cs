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
        HourlyGraphUserControl hourlyGraph;
        HourlyDetailsUserControl hourlyDetails;

        DateTime selectedDate;

        public MainInfoView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            mainInfoPresenter = new MainInfoPresenter(this, new OpenWeatherMapWeatherInfoGetter("d03069ad008b108f3f6e60663a3587f1"));
            hourlyGraph = new HourlyGraphUserControl();
            hourlyDetails = new HourlyDetailsUserControl();
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
                IconPictureBox.Load(mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.IconPath);
                DescriptionLabel.Text = mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.Description;
                LastUpdateTimeLabel.Text = $"Last update time {mainInfoPresenter.CityWeathers[selectedCity].LastUpdateTime.ToShortTimeString()}";
                PressureLabel.Text = $"Pressure {mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.Pressure} hPa";
                HumidityLabel.Text = $"Humidity {mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.Humidity} %";
                WindLabel.Text = $"Wind {mainInfoPresenter.CityWeathers[selectedCity].CurrentWeather.WindSpeed} m/s";
                UpdateDailyWeatherColumn();
                (DailyWeatherInfoTableLayoutPanel.Controls[0] as DailyItemUserControl)?.ItemClick(null, null);
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
                dailyItemUserControl.DateOfDay = dailyWeathers[i].Date.Date;
                dailyItemUserControl.DateLabel.Text = $"{dailyWeathers[i].Date.Day}, {dailyItemUserControl.DateOfDay.DayOfWeek.ToString().Substring(0, 3)}";
                dailyItemUserControl.MaxTemperatureLabel.Text = dailyWeathers[i].MaxTemperature.ToString();
                dailyItemUserControl.MinTemperatureLabel.Text = dailyWeathers[i].MinTemperature.ToString();
                dailyItemUserControl.WasClicked += ChangeSelectedHourlyItem;

                DailyWeatherInfoTableLayoutPanel.ColumnCount++;
                DailyWeatherInfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                DailyWeatherInfoTableLayoutPanel.Controls.Add(dailyItemUserControl, i, 0);
            }
        }

        void ChangeSelectedHourlyItem(object sender, DateTime date)
        {
            selectedDate = date;
            foreach(DailyItemUserControl item in DailyWeatherInfoTableLayoutPanel.Controls)
            {
                if(sender == item)
                {
                    item.Selected = true;
                }
                else
                {
                    item.Selected = false;
                }
            }
            UpdateHourlyColumn();
        }

        void UpdateHourlyColumn()
        {
            List<Weather> hourlyWeathersForSelectedDay = mainInfoPresenter.CityWeathers[CitiesComboBox.SelectedItem as string].ForecastListOfWeathers.Where(w => w.Date.Date == selectedDate).ToList<Weather>();
            ((IHourlyUpdate)HourlyColumnTableLayoutPanel.Controls[1]).UpdateHourly(hourlyWeathersForSelectedDay);

        }

        public void UpdateListOfCitites(string city)
        {
            string previousSelectedCity = CitiesComboBox.SelectedItem as string;
            CitiesComboBox.DataSource = mainInfoPresenter.CityWeathers.Keys.ToList();
            if (mainInfoPresenter.CityWeathers.Keys.Contains(city))
            {
                CitiesComboBox.SelectedItem = city;
            }
            else if (mainInfoPresenter.CityWeathers.Keys.Contains(previousSelectedCity))
            {
                CitiesComboBox.SelectedItem = previousSelectedCity;
            }
            else
            {
                CitiesComboBox.SelectedItem = mainInfoPresenter.CityWeathers.Keys.FirstOrDefault();
            }
            NewCityTextBox.Text = "";
            
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
            selectedDate = mainInfoPresenter.CityWeathers[CitiesComboBox.SelectedItem as string].CurrentWeather.Date.Date;
            UpdateInfoViewAboutWeather();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            if(HourlyColumnTableLayoutPanel.Controls[1] != hourlyGraph)
            {
                TurnToSelectedTypeOfHourlyColumnDisplay(hourlyGraph);
            }
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            if (HourlyColumnTableLayoutPanel.Controls[1] != hourlyDetails)
            {
                TurnToSelectedTypeOfHourlyColumnDisplay(hourlyDetails);
            }
        }

        void TurnToSelectedTypeOfHourlyColumnDisplay(UserControl control)
        {
            HourlyColumnTableLayoutPanel.Controls.RemoveAt(1);
            HourlyColumnTableLayoutPanel.Controls.Add(control);
            UpdateHourlyColumn();
        }

        private void RemoveCityButton_Click(object sender, EventArgs e)
        {
            var removeWindow = new RemoveView(mainInfoPresenter);
            removeWindow.ShowDialog();
        }
    }
}
