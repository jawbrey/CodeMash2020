using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CMWeather.Models;

namespace CMWeather.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            CurrentWeather = null;

            var locations = App.Database.GetItems();

            Locations = new ObservableCollection<SavedLocation>(locations);
        }


        public WeatherModel CurrentWeather { get; set; }
        public ObservableCollection<SavedLocation> Locations { get; set; }
        public string Zip { get; set; }
    }
}

