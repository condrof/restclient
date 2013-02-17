using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JohnsRestWeatherService.DataContracts;

namespace restClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherService.RestWeatherServiceClient client = new WeatherService.RestWeatherServiceClient();
            WeatherService.WeatherInfo w = new WeatherService.WeatherInfo()
            {
                city = "Dublin",
                Temperature = 20f,
                windInfo = new WeatherService.WindInfo()
                {
                    AvgWindSpeed_KM = 6.0f,
                    windSpeed_KM = 4.0f
                }
            };
            String ret = client.UpdateWeather(w);
            Console.WriteLine("city is now: " + w.city);

            Console.ReadLine();

        }
    }
}
