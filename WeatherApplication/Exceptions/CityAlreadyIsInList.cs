using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Exceptions
{
    class CityAlreadyIsInList: Exception
    {
        public CityAlreadyIsInList(): base("City is already added to list")
        {

        }
    }
}
