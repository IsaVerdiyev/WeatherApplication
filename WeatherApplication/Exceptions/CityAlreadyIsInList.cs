using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Exceptions
{
    class CityAlreadyIsInListException: Exception
    {
        public CityAlreadyIsInListException(): base("City is already added to list")
        {

        }
        public CityAlreadyIsInListException(string message): base(message)
        {

        }
    }
}
