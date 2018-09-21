using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Model;

namespace WeatherApplication.View.SubViews
{
    interface IHourlyUpdate
    {
        void UpdateHourly(List<Weather> weathersOfDay);
    }
}
