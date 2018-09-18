using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApplication.Model;
using WeatherApplication.Services.WeatherInfoGetter.Exceptions;

namespace WeatherApplication.Services.WeatherInfoGetter
{
    class OpenWeatherMapWeatherInfoGetter : IWeatherInfoGetter
    {
        string firstPartOfRequestCurrent = "http://api.openweathermap.org/data/2.5/weather?&units=metric&q=";
        string firstPartOfRequestForecast = "http://api.openweathermap.org/data/2.5/forecast?&units=metric&q=";
        string secondPartOfRequest = "&APPID=";

        string apiKey;

        public OpenWeatherMapWeatherInfoGetter(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public Weather GetCurrentWeatherOfCity(string city)
        {
            string response = GetCurrentWeatherResponseFromWeatherOpenMap(city);
            return ParseJsonCurrentWeatherResponseIntoWeather(response);
        }

        public async Task<Weather> GetCurrentWeatherOfCityAsync(string city)
        {
            string response = await GetCurrentWeatherResponseFromWeatherOpenMapAsync(city);
            return ParseJsonCurrentWeatherResponseIntoWeather(response);
        }

        public List<Weather> GetForecastWeathersOfCity(string city)
        {
            string response = GetForecastResponseFromWeatherOpenMap(city);
            return ParseJsonForecastResponseIntoListOfWeathers(response);
        }

        public async Task<List<Weather>> GetForecastWeathersOfCityAsync(string city)
        {
            string response = await GetForecastResponseFromWeatherOpenMapAsync(city);
            return ParseJsonForecastResponseIntoListOfWeathers(response);
        }

        string GetCurrentWeatherResponseFromWeatherOpenMap(string city)
        {
            using(WebClient client = new WebClient())
            {
                return client.DownloadString($"{ firstPartOfRequestCurrent}{ city}{secondPartOfRequest}{apiKey}");
            }
        }

        async Task<string> GetCurrentWeatherResponseFromWeatherOpenMapAsync(string city)
        {
            using (WebClient client = new WebClient())
            {
                return await client.DownloadStringTaskAsync($"{ firstPartOfRequestCurrent}{ city}{secondPartOfRequest}{apiKey}");
            }
        }

        string GetForecastResponseFromWeatherOpenMap(string city)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString($"{firstPartOfRequestForecast}{city}{secondPartOfRequest}{apiKey}");
            }
        }

        async Task<string> GetForecastResponseFromWeatherOpenMapAsync(string city)
        {
            using(WebClient client = new WebClient())
            {
                return await client.DownloadStringTaskAsync($"{firstPartOfRequestForecast}{city}{secondPartOfRequest}{apiKey}");
            }
        }

        List<Weather> ParseJsonForecastResponseIntoListOfWeathers(string jsonResponse)
        {
            JObject jObj = JObject.Parse(jsonResponse);

            if(jObj["cod"].Value<string>()=="404" && jObj["message"].Value<string>() == "city not found")
            {
                throw new CityNotFoundException();
            }

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

        Weather ParseJsonCurrentWeatherResponseIntoWeather(string jsonResponse)
        {
            JObject jObj = JObject.Parse(jsonResponse);

            Weather currentWeather = new Weather
            {
                Temperature = jObj["main"]["temp"].Value<double>(),
                Date = DateTimeExtensions.GetDateFromSecondsSince1970(jObj["dt"].Value<int>()),
                Description = jObj["weather"][0]["description"].Value<string>(),
                MaxTemperature = jObj["main"]["temp_max"].Value<double>(),
                MinTemperature = jObj["main"]["temp_min"].Value<double>(),
                Humidity = jObj["main"]["humidity"].Value<double>(),
                Pressure = jObj["main"]["pressure"].Value<double>(),
                WindSpeed = jObj["wind"]["speed"].Value<double>(),
                IconPath = jObj["weather"][0]["icon"].Value<string>()
            };
            return currentWeather;
        }

    }
}
