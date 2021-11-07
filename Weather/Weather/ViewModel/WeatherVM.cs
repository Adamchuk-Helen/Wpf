using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;
using Weather.ViewModel.Helpers;

namespace Weather.ViewModel
{
    public class WeatherVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private CurrentConditions currentConditions;

        private FiveDaysWeather fiveDaysWeather;

        public CurrentConditions CurrentConditions
        {
            get => currentConditions;
            set
            {
                currentConditions = value;
              
                OnNotify();
            }
        }

        public SearchCommand searchCommand { get; set; }

        private City selectedCity;

        public City SelectedCity
        {
            get => selectedCity;
            set 
            {
                selectedCity=value;
                GetConditionsAsync();
                //GetFiveDaysAsync();
                OnNotify();
            }
                
        }

        public FiveDaysWeather FiveDaysWeather
        {
            get => fiveDaysWeather;
            set 
            {
                fiveDaysWeather = value;
                GetFiveDaysAsync();
                OnNotify();
            }
        }

        private async void GetConditionsAsync()
        {
            if (SelectedCity != null)
            {
                CurrentConditions = await WeatherHelper.GetCurrentConditionsAsynk(SelectedCity.Key);
            }
            else
            {
                CurrentConditions = new CurrentConditions();
            }
        }

        private async void GetFiveDaysAsync()
        {
            if (SelectedCity != null)
            {
                fiveDaysWeather = await WeatherHelper.GetFiveDaysWeatherAsynk(SelectedCity.Key);
            }
            else
            {
                fiveDaysWeather = new FiveDaysWeather();
            }
        }



        public WeatherVM()
        {
            query = "";
            searchCommand = new SearchCommand(this);
            
        }


        private string query ;
        public string Query
        { get { return query; }
            set { query= value; }

        }

        public ObservableCollection<City> Cities { get; set; } = new ObservableCollection<City>();
        public ObservableCollection<FiveDaysWeather> WeatherFiveDays { get; set; } = new ObservableCollection<FiveDaysWeather>();
        public void OnNotify([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public async Task MakeRequestCityAsync()
        {
           Cities.Clear();
            var cities = await WeatherHelper.GetCitiesAsynk(Query);
           
            foreach (var item in cities)
            {
                Cities.Add(item);
            }
        }


    }
}
