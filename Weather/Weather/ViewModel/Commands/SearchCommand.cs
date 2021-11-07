using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Weather.ViewModel.Helpers
{
    public class SearchCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
       

        WeatherVM VM { get; set; }

        public SearchCommand(WeatherVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            await VM.MakeRequestCityAsync();
        }

    }
}
