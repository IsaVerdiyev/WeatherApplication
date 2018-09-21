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
            HourlyItemUserControl hourlyItem;
            foreach (var weather in weathersOfDay)
            {
                hourlyItem = new HourlyItemUserControl();
                hourlyItem.TemperatureLabel.Text = $"{weather.Temperature.ToString()} °C";
                hourlyItem.DescriptionLabel.Text = weather.Description.ToString();
                hourlyItem.WindLabel.Text = $"{weather.WindSpeed.ToString()} m/s";

                HourlyDetailsTableLayoutPanel.ColumnCount++;
                HourlyDetailsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                HourlyDetailsTableLayoutPanel.Controls.Add(hourlyItem);
            }
        }
    }
}
