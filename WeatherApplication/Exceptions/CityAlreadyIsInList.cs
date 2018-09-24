using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Exceptions
{
    class CityAlreadyIsInListException: Exception
    {
        public string City { get; private set; }
        public CityAlreadyIsInListException(string city): base("City is already added to list")
        {
            City = city;
        }
        public CityAlreadyIsInListException(string message, string city): base(message)
        {
            City = city;
        }
    }
}
