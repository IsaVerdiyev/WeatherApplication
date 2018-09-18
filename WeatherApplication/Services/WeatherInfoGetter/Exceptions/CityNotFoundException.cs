using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Services.WeatherInfoGetter.Exceptions
{
    class CityNotFoundException: Exception
    {
        public CityNotFoundException(string message) : base(message)
        {

        }

        public CityNotFoundException()
        {

        }
    }
}
