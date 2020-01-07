using System;
using System.Collections.Generic;
using CMWeather.Models;
using Xamarin.Forms;

namespace CMWeather
{
    public partial class WeatherDetail : ContentPage
    {
        public WeatherDetail(SavedLocation data)
        {
            InitializeComponent();

            this.Title = data.Name;
        }
    }
}
