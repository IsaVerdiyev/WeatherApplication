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
using System.Configuration;

namespace WeatherApplication.View
{
    public partial class MainView : UserControl, IMainView
    {
        IMainInfoPresenter mainInfoPresenter;

        IUpdateWeatherInfoView weatherInfoView;

        NoCitiesView noCitiesView;

        

        public MainView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            mainInfoPresenter = new MainInfoPresenter(this, new OpenWeatherMapWeatherInfoGetter(ConfigurationManager.AppSettings.Get("Api")));
           
            weatherInfoView = new WeatherInfoView(mainInfoPresenter);
            noCitiesView = new NoCitiesView();
            MainTableLayoutPanel.Controls.Add(noCitiesView);

            
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
                   CitiesComboBox.SelectedItem = mainInfoPresenter.CityWeathers.Keys.FirstOrDefault(c => c == ex.City);
                   NewCityTextBox.Text = "";
               }
               catch (CityNameIsNullOrWhiteSpaceException ex)
               {

               }
               catch (CityNotFoundException ex)
               {
                   MessageBox.Show("City wasn't found");
               }
               catch(RequestLimitationExcedeedException ex)
               {
                   MessageBox.Show(ex.Message);
               }
               catch(InvalidApiException ex)
               {
                   MessageBox.Show($"Invalid api key {ex.ApiKey}\n Need to change api key in source code and recompile application","", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               catch (WebException ex)
               {
                   MessageBox.Show("There is no internet. Check internet connection");
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.GetBaseException().Message + "\n" + ex.GetBaseException().StackTrace, "Exception inside mainInfoPresenter.AddCity happened ", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            mainInfoPresenter.SelectedCity = CitiesComboBox.SelectedItem as string;
            UpdateWeatherInfoView();
        }


        private void RemoveCityButton_Click(object sender, EventArgs e)
        {
            var removeWindow = new RemoveView(mainInfoPresenter);
            removeWindow.ShowDialog();
        }

        public void UpdateCitiesView()
        {
            CitiesComboBox.SelectedIndexChanged -= CitiesComboBox_SelectedIndexChanged;
            CitiesComboBox.DataSource = mainInfoPresenter.CityWeathers.Keys.ToList();
            
            CitiesComboBox.SelectedItem = mainInfoPresenter.SelectedCity;
            if (mainInfoPresenter.SelectedCity == null)
            {
                CitiesComboBox.Text = "";
            }
            NewCityTextBox.Text = "";
            CitiesComboBox.SelectedIndexChanged += CitiesComboBox_SelectedIndexChanged;
        }

        public void UpdateWeatherInfoView()
        {
            if (mainInfoPresenter.SelectedCity == null)
            {
                if (MainTableLayoutPanel.Controls[1] != noCitiesView)
                {
                    MainTableLayoutPanel.Controls.RemoveAt(1);
                    MainTableLayoutPanel.Controls.Add(noCitiesView);
                }
            }

            else { 
                if (MainTableLayoutPanel.Controls[1] != weatherInfoView)
                {
                    MainTableLayoutPanel.Controls.RemoveAt(1);
                    MainTableLayoutPanel.Controls.Add(weatherInfoView as UserControl);
                }
                weatherInfoView.UpdateWeatherInfoView();
            }

        }

        private void NewCityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                AddCity();
            }
        }
    }
}
