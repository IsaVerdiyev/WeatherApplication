using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApplication.Presenter;

namespace WeatherApplication.View
{
    public partial class RemoveView : Form
    {
        IMainInfoPresenter mainInfoPresenter;
        public RemoveView(IMainInfoPresenter mainInfoPresenter)
        {
            InitializeComponent();
            this.mainInfoPresenter = mainInfoPresenter;
            CitiesListBox.DataSource = mainInfoPresenter.CityWeathers.Keys.ToList();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            mainInfoPresenter.RemoveCity(CitiesListBox.SelectedItem as string);
            this.Close();
        }
    }
}
