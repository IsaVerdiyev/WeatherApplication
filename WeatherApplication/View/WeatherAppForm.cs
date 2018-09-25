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
            InitializeTasksInConstuctor();
            UpdateAllCitiesThroughTimer();
        }

        async void UpdateAllCitiesThroughTimer()
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

        void InitializeTasksInConstuctor()
        {
            Task loadTaskFromSave = mainInfoPresenter.LoadStorageFromSaveIfExistAsync();
            Task UpdateInfoFromNetAndUpdateView = loadTaskFromSave.ContinueWith(tLoadFromSave =>
            {
                foreach (var city in mainInfoPresenter.CityWeathers.Keys)
                {
                    mainInfoPresenter.UpdateInfoOfSelectedCityAsync(city).ContinueWith(tLoadFromNet =>
                    {
                        try
                        {
                            throw tLoadFromNet.Exception.InnerExceptions.FirstOrDefault();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Exception occured in UpdateInfoOfSelectedCityAsync method \n{ex.Message}\n{ex.StackTrace}");
                        }
                    }, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.FromCurrentSynchronizationContext());
                }
                (MainPanel.Controls[0] as IMainView).UpdateCitiesView();
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

    }
}
