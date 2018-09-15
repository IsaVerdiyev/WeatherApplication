using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApplication.Model;

namespace WeatherApplication.Services
{
    class OpenWeatherMapWeatherInfoGetter : IWeatherInfoGetter
    {
        string firstPartOfRequestForecast = "http://api.openweathermap.org/data/2.5/forecast?&units=metric&q=";
        string secondPartOfRequest = "&APPID=";

        string apiKey;

        public OpenWeatherMapWeatherInfoGetter(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public List<Weather> GetWeathersOfCity(string city)
        {
            string response = GetResponseFromWeatherOpenMap(city);
            return ParseJsonResponseIntoListOfWeathers(response);
        }

        public async Task<List<Weather>> GetWeathersOfCityAsync(string city)
        {
            string response = await GetResponseFromWeatherOpenMapAsync(city);
            return ParseJsonResponseIntoListOfWeathers(response);
        }

        string GetResponseFromWeatherOpenMap(string city)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString($"{firstPartOfRequestForecast}{city}{secondPartOfRequest}{apiKey}");
            }
        }

        async Task<string> GetResponseFromWeatherOpenMapAsync(string city)
        {
            using(WebClient client = new WebClient())
            {
                return await client.DownloadStringTaskAsync($"{firstPartOfRequestForecast}{city}{secondPartOfRequest}{apiKey}");
            }
        }

        List<Weather> ParseJsonResponseIntoListOfWeathers(string jsonResponse)
        {
            JObject jObj = JObject.Parse(jsonResponse);

            List<Weather> list = jObj["list"].Select(w => new Weather
                {
                    Temperature = w.SelectToken("main.temp").Value<double>(),
                    Date = w.SelectToken("dt_txt").Value<DateTime>(),
                    MaxTemperature = w.SelectToken("main.temp_max").Value<double>(),
                    MinTemperature = w.SelectToken("main.temp_min").Value<double>(),
                    Pressure = w.SelectToken("main.pressure").Value<double>(),
                    Humidity = w.SelectToken("main.humidity").Value<double>(),
                    WindSpeed = w.SelectToken("wind.speed").Value<double>(),
                    Description = w.SelectToken("weather[0].description").Value<string>(),
                    IconPath = w.SelectToken("weather[0].icon").Value<string>()
                }).ToList<Weather>();
            return list;
        }



    }
}
