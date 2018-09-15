﻿using System;
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

namespace WeatherApplication.View
{
    public partial class MainInfoView : UserControl
    {
        IWeatherInfoGetter weatherInfoGetter;
        public MainInfoView()
        {
            InitializeComponent();
            weatherInfoGetter = new OpenWeatherMapWeatherInfoGetter("d03069ad008b108f3f6e60663a3587f1");
            Task<List<Weather>> weathers = weatherInfoGetter.GetWeathersOfCityAsync("Baku");
            listBox1.DataSource = weathers.Result;
        }
    }
}
