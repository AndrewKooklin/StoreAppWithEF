using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace StoreWithEF.Commands
{
    public class LogInCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if(parameter is StackPanel)
            {
                var sp = (StackPanel)parameter;
                var spChildren = sp.Children;
                TextBox userName = (TextBox)spChildren[0];
                PasswordBox password = (PasswordBox)spChildren[1];


                return true;
            }
            else
            {
                return false;
            }
        }

        public void Execute(object parameter)
        {
            
        }
    }
}
