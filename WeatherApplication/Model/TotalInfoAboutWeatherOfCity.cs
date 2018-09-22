using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Model
{
    public class TotalInfoAboutWeatherOfCity
    {
        private Weather currentWeather;

        public Weather CurrentWeather
        {
            get { return currentWeather; }
            set { currentWeather = value; }
        }

        private List<Weather> forecastListOfWeathers;

        public List<Weather> ForecastListOfWeathers
        {
            get { return forecastListOfWeathers; }
            set { forecastListOfWeathers = value; }
        }

        private DateTime lastUpdateTime;

        public DateTime LastUpdateTime
        {
            get { return lastUpdateTime; }
            set { lastUpdateTime = value; }
        }



    }
}
