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
        public LogInCommand()
        {
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            if (parameter != null)
            {
                var values = (object[])parameter;
                string userNameValue = values[0].ToString();
                PasswordBox passwordBox = (PasswordBox)values[1];
                string passwordValue = passwordBox.Password;
                Label label = (Label)values[2];
                string labelContent = label.Content.ToString();

            }
        }
    }
}
