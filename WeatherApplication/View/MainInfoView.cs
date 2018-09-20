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

        public void UpdateInfoAboutWeather()
        {
            throw new NotImplementedException();
        }

        public void UpdateListOfCitites(string city)
        {
            throw new NotImplementedException();
        }
    }
}
