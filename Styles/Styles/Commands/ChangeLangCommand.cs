using Styles.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Styles.Commands
{
    public class ChangeLangCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;



        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           Cha
        }

        
    }
}
