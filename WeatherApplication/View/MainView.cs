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
    public partial class MainView : UserControl, IMainView
    {
        IMainInfoPresenter mainInfoPresenter;

        IUpdateWeatherInfoView weatherInfoView;

        NoCitiesView noCitiesView;

        

        public MainView()
        {
            InitializeComponent();
            mainInfoPresenter = new MainInfoPresenter(this, new OpenWeatherMapWeatherInfoGetter("d03069ad008b108f3f6e60663a3587f1"));
            InitializeTasksInConstuctor();
            this.Dock = DockStyle.Fill;


            weatherInfoView = new WeatherInfoView(mainInfoPresenter);
            noCitiesView = new NoCitiesView();
            MainTableLayoutPanel.Controls.Add(noCitiesView);

            
        }

        void InitializeTasksInConstuctor()
        {
            Task loadTaskFromSave = mainInfoPresenter.LoadStorageFromSaveIfExistAsync();
            Task UpdateInfoFromNetAndUpdateView = loadTaskFromSave.ContinueWith(tLoadFromSave =>
            {
                foreach(var city in mainInfoPresenter.CityWeathers.Keys)
                {
                    mainInfoPresenter.UpdateInfoOfSelectedCityAsync(city).ContinueWith(tLoadFromNet =>
                    {
                        try
                        {
                            throw tLoadFromNet.Exception.InnerExceptions.FirstOrDefault();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"Exception occured in UpdateInfoOfSelectedCityAsync method \n{ex.Message}\n{ex.StackTrace}");
                        }
                    }, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.FromCurrentSynchronizationContext());
                }
            }, CancellationToken.None, TaskContinuationOptions.OnlyOnRanToCompletion, TaskScheduler.FromCurrentSynchronizationContext());

            

            loadTaskFromSave.ContinueWith(tLoadTaskFromSave =>
            {
                try
                {
                    throw tLoadTaskFromSave.Exception.InnerExceptions.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception occured in LoadStorageFromSaveIfExistAsync method \n{ex.Message}\n{ex.StackTrace}");
                }
            }, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.FromCurrentSynchronizationContext());

            UpdateInfoFromNetAndUpdateView.ContinueWith(tLoadFromNetCommon =>
            {
                try
                {
                    throw tLoadFromNetCommon.Exception.InnerExceptions.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception occured in LoadFromNetUpdatedInfoTask task \n{ex.Message}\n{ex.StackTrace}");
                }
            }, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.FromCurrentSynchronizationContext());
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
