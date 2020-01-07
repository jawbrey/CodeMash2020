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
            Locations = new ObservableCollection<SavedLocation>();
        }

        public WeatherModel CurrentWeather { get; set; }
        public ObservableCollection<SavedLocation> Locations { get; set; }
    }
}

