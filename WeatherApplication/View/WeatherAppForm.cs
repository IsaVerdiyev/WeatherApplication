using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApplication.Presenter;
using WeatherApplication.Services.WeatherInfoGetter;

namespace WeatherApplication.View
{
    public partial class WeatherAppForm : Form
    {
        IMainInfoPresenter mainInfoPresenter;

        
        
        public WeatherAppForm()
        {
            InitializeComponent();
            MainPanel.Controls.Add(new MainView());
            mainInfoPresenter = new MainInfoPresenter(MainPanel.Controls[0] as IMainView, new OpenWeatherMapWeatherInfoGetter(ConfigurationManager.AppSettings.Get("Api")));
            UpdateAllCities();
        }

        async void UpdateAllCities()
        {
            while (true)
            {
                foreach (var city in mainInfoPresenter.CityWeathers.Keys)
                {
                    Task t = mainInfoPresenter.UpdateInfoOfSelectedCityAsync(city);
                }
                await Task.Delay(new TimeSpan(1, 0, 0));
            }
        }
    }
}
