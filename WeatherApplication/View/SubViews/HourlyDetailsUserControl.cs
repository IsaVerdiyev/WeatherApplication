using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApplication.Model;
using System.Globalization;

namespace WeatherApplication.View.SubViews
{
    public partial class HourlyDetailsUserControl : UserControl, IHourlyUpdate
    {
        public HourlyDetailsUserControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public void UpdateHourly(List<Weather> weathersOfDay)
        {
            HourlyDetailsTableLayoutPanel.ColumnCount = 0;
            HourlyDetailsTableLayoutPanel.ColumnStyles.Clear();
            HourlyDetailsTableLayoutPanel.Controls.Clear();
            HourlyItemUserControl hourlyItem;
            foreach (var weather in weathersOfDay)
            {
                hourlyItem = new HourlyItemUserControl();
                hourlyItem.IconPictureBox.Load(weather.IconPath);
                hourlyItem.TemperatureLabel.Text = $"{weather.Temperature.ToString()} °C";
                hourlyItem.DescriptionLabel.Text = weather.Description.ToString();
                hourlyItem.HumidityLabel.Text = $"Humidity {weather.Humidity} %";
                hourlyItem.WindLabel.Text = $"💨 {weather.WindSpeed} m/s";
                hourlyItem.HourLabel.Text = weather.Date.ToString("hh tt", CultureInfo.InvariantCulture);

                HourlyDetailsTableLayoutPanel.ColumnCount++;
                HourlyDetailsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                HourlyDetailsTableLayoutPanel.Controls.Add(hourlyItem);
            }
        }
    }
}
