using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Services.WeatherInfoGetter.Exceptions
{
    class InvalidApiException: Exception
    {
        public string ApiKey { get; set; }
        public InvalidApiException(string apiKey, string message = "Invalid api key"): base(message)
        {

        }
    }
}
