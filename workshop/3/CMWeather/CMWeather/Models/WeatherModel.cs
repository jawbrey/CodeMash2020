using System;
namespace CMWeather.Models
{
    public class WeatherModel
    {
        public WeatherModel()
        {
        }

        public string Location { get; set; }
        public decimal Temp { get; set; }
    }
}
