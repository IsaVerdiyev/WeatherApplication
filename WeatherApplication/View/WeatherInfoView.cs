using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApplication.View.SubViews;
using WeatherApplication.Services.StorageService;
using WeatherApplication.Model;

namespace WeatherApplication.View
{
    public partial class WeatherInfoView : UserControl, IUpdateWeatherInfoView
    {
        HourlyGraphUserControl hourlyGraph;
        HourlyDetailsUserControl hourlyDetails;

        DateTime selectedDate;

        string previousSelectedCity;

        public WeatherInfoView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            hourlyGraph = new HourlyGraphUserControl();
            hourlyDetails = new HourlyDetailsUserControl();
            HourlyColumnTableLayoutPanel.Controls.Add(hourlyGraph);
        }

        public void UpdateWeatherInfoView()
        {
            string selectedCity = Storage.StorageInstance.SelectedCity;
            if (previousSelectedCity != selectedCity || LastUpdateTimeLabel.Text != Storage.StorageInstance.CityWeathers[selectedCity].LastUpdateTime.ToShortTimeString())
            {

                CityNameLabel.Text = selectedCity;
                DegreeLabel.Text = Storage.StorageInstance.CityWeathers[selectedCity].CurrentWeather.Temperature.ToString() + "°C";
                IconPictureBox.Load(Storage.StorageInstance.CityWeathers[selectedCity].CurrentWeather.IconPath);
                DescriptionLabel.Text = Storage.StorageInstance.CityWeathers[selectedCity].CurrentWeather.Description;
                LastUpdateTimeLabel.Text = $"Last update time {Storage.StorageInstance.CityWeathers[selectedCity].LastUpdateTime.ToShortTimeString()}";
                PressureLabel.Text = $"Pressure {Storage.StorageInstance.CityWeathers[selectedCity].CurrentWeather.Pressure} hPa";
                HumidityLabel.Text = $"Humidity {Storage.StorageInstance.CityWeathers[selectedCity].CurrentWeather.Humidity} %";
                WindLabel.Text = $"Wind {Storage.StorageInstance.CityWeathers[selectedCity].CurrentWeather.WindSpeed} m/s";
                UpdateDailyWeatherColumn();
                (DailyWeatherInfoTableLayoutPanel.Controls[0] as DailyItemUserControl)?.ItemClick(null, null);
                previousSelectedCity = selectedCity;
            }
        }

        void UpdateDailyWeatherColumn()
        {
            var dailyWeathers = (from weather in Storage.StorageInstance.CityWeathers[Storage.StorageInstance.SelectedCity].ForecastListOfWeathers
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
            foreach (DailyItemUserControl item in DailyWeatherInfoTableLayoutPanel.Controls)
            {
                if (sender == item)
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
            List<Weather> hourlyWeathersForSelectedDay = Storage.StorageInstance.CityWeathers[Storage.StorageInstance.SelectedCity].ForecastListOfWeathers.Where(w => w.Date.Date == selectedDate).ToList<Weather>();
            ((IHourlyUpdate)HourlyColumnTableLayoutPanel.Controls[1]).UpdateHourly(hourlyWeathersForSelectedDay);

        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            if (HourlyColumnTableLayoutPanel.Controls[1] != hourlyGraph)
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

    }


}
