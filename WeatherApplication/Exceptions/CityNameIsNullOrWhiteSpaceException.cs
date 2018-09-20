using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Exceptions
{
    class CityNameIsNullOrWhiteSpaceException: Exception
    {
        public CityNameIsNullOrWhiteSpaceException(string message): base(message)
        {

        }

        public CityNameIsNullOrWhiteSpaceException(): base("City name cannot be null or white space")
        {

        }
    }
}
