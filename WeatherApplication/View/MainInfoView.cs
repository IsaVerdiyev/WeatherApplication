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

namespace WeatherApplication.View
{
    public partial class MainInfoView : UserControl, IMainInfoView
    {
        IMainInfoPresenter mainInfoPresenter;
        public MainInfoView()
        {
            InitializeComponent();
            mainInfoPresenter = new MainInfoPresenter(this, new OpenWeatherMapWeatherInfoGetter("d03069ad008b108f3f6e60663a3587f1"));
        }

        public void UpdateListOfCitites(string city)
        {

            string selectedCity = CityListBox.SelectedItem as string;
            CityListBox.DataSource = null;
                       
            CityListBox.SelectionMode = SelectionMode.None;
            CityListBox.SelectionMode = SelectionMode.One;
            CityListBox.DataSource = mainInfoPresenter.CityWeathers.Keys.ToList();

            if (mainInfoPresenter.CityWeathers.ContainsKey(city))
            {
                CityListBox.SelectedItem = null;

                CityListBox.SelectedItem = selectedCity;

            }


            UpdateListOfDescriptions();
        }

        public void UpdateListOfDescriptions()
        {
            if (CityListBox.SelectedItem != null)
            {
                DescriptionListBox.DataSource = null;
                DescriptionListBox.DataSource = new List<DateTime> { mainInfoPresenter.CityWeathers[CityListBox.SelectedItem as string].LastUpdateTime };
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            mainInfoPresenter.AddCity(CityTextBox.Text);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            mainInfoPresenter.RemoveCity(CityListBox.SelectedItem?.ToString());
        }

        private void CityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListOfDescriptions();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string selectedCity = CityListBox.SelectedItem as string;
            if (selectedCity != null)
            {
                mainInfoPresenter.UpdateInfoOfSelectedCity(selectedCity);
            }
        }

        public void UpdateInfoAboutWeather()
        {
            UpdateListOfDescriptions();
        }
    }
}
