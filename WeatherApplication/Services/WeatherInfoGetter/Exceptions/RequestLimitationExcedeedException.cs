using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Services.WeatherInfoGetter.Exceptions
{
    class RequestLimitationExcedeedException: Exception
    {
        public RequestLimitationExcedeedException(string message = "Request limitation was exceeded"):base(message)
        {

        }
    }
}
