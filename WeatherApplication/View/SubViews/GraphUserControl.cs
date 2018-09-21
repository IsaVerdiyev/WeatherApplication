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
    public partial class GraphUserControl : UserControl, IHourlyUpdate
    {
        public GraphUserControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public void UpdateHourly(List<Weather> weathersOfDay)
        {
            HourlyGraphic.Series["Hours"].Points.Clear();
            foreach(var weather in weathersOfDay)
            {
                HourlyGraphic.Series["Hours"].Points.AddXY(weather.Date.Hour, weather.Temperature);
            }
        }
    }
}
