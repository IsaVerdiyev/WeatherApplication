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
            
        }

        public void UpdateListOfCitites(string city)
        {
            CitiesComboBox.DataSource = mainInfoPresenter.CityWeathers.Keys.ToList();
            CitiesComboBox.SelectedItem = city;
            NewCityTextBox.Text = "";
            UpdateInfoAboutWeather();
        }

        void AddCity()
        {
            try
            {
                mainInfoPresenter.AddCity(NewCityTextBox.Text);
            }
            catch(CityAlreadyIsInListException ex)
            {
                CitiesComboBox.SelectedItem = mainInfoPresenter.CityWeathers.Keys.Select(c => c == NewCityTextBox.Text);
                return;
            }
            catch(CityNameIsNullOrWhiteSpaceException ex)
            {
                MessageBox.Show("Something");
                return;
            }
            catch(CityNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch(WebException ex)
            {
                MessageBox.Show("There is no internet. Check internet connection");
                return;
            }
        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            AddCity();
        }
    }
}
