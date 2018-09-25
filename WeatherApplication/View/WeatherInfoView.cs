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
using WeatherApplication.Presenter;
using System.Threading;

namespace WeatherApplication.View
{
    public partial class WeatherInfoView : UserControl, IUpdateWeatherInfoView
    {
        HourlyGraphUserControl hourlyGraph;
        HourlyDetailsUserControl hourlyDetails;

        IMainInfoPresenter mainInfoPresenter;

        DateTime selectedDate;

        string previousSelectedCity;
        private CancellationToken cancellationToken;

        public WeatherInfoView(IMainInfoPresenter mainInfoPresenter)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            hourlyGraph = new HourlyGraphUserControl();
            hourlyDetails = new HourlyDetailsUserControl();
            HourlyColumnTableLayoutPanel.Controls.Add(hourlyGraph);

            this.mainInfoPresenter = mainInfoPresenter;
        }

        public void UpdateWeatherInfoView()
        {
           
            if (previousSelectedCity != mainInfoPresenter.SelectedCity || LastUpdateTimeLabel.Text != mainInfoPresenter.CityWeathers[mainInfoPresenter.SelectedCity].LastUpdateTime.ToShortTimeString())
            {

                CityNameLabel.Text = mainInfoPresenter.SelectedCity;
                DegreeLabel.Text = mainInfoPresenter.CityWeathers[mainInfoPresenter.SelectedCity].CurrentWeather.Temperature.ToString() + "°C";
                IconPictureBox.Load(mainInfoPresenter.CityWeathers[mainInfoPresenter.SelectedCity].CurrentWeather.IconPath);
                DescriptionLabel.Text = mainInfoPresenter.CityWeathers[mainInfoPresenter.SelectedCity].CurrentWeather.Description;
                LastUpdateTimeLabel.Text = $"Last update time {mainInfoPresenter.CityWeathers[mainInfoPresenter.SelectedCity].LastUpdateTime.ToShortTimeString()}";
                PressureLabel.Text = $"Pressure {mainInfoPresenter.CityWeathers[mainInfoPresenter.SelectedCity].CurrentWeather.Pressure} hPa";
                HumidityLabel.Text = $"Humidity {mainInfoPresenter.CityWeathers[mainInfoPresenter.SelectedCity].CurrentWeather.Humidity} %";
                WindLabel.Text = $"Wind {mainInfoPresenter.CityWeathers[mainInfoPresenter.SelectedCity].CurrentWeather.WindSpeed} m/s";
                UpdateDailyWeatherColumn();
                (DailyWeatherInfoTableLayoutPanel.Controls[0] as DailyItemUserControl)?.ItemClick(null, null);
                previousSelectedCity = mainInfoPresenter.SelectedCity;
            }
        }

        void UpdateDailyWeatherColumn()
        {
            var dailyWeathers = (from weather in mainInfoPresenter.CityWeathers[mainInfoPresenter.SelectedCity].ForecastListOfWeathers
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
            List<Weather> hourlyWeathersForSelectedDay = mainInfoPresenter.CityWeathers[mainInfoPresenter.SelectedCity].ForecastListOfWeathers.Where(w => w.Date.Date == selectedDate).ToList<Weather>();
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            mainInfoPresenter.UpdateInfoOfSelectedCityAsync(mainInfoPresenter.SelectedCity).ContinueWith(t =>
            {
                try
                {
                    t.Exception.InnerExceptions.FirstOrDefault();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Exception occured in UpdateButton_Click function \n {ex.Message}\n{ex.StackTrace}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }


}
