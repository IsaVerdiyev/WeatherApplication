﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.View
{
    interface IMainInfoView
    {
        void UpdateListOfCitites(string city);
        void UpdateInfoAboutWeather();
    }
}
