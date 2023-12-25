using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace StoreWithEF.Commands
{
    public class GetPasswordStringCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if(parameter is StackPanel)
            {
                return true;
            }
            else return false;
        }

        public void Execute(object parameter)
        {
            if (parameter is StackPanel)
            {
                var stackPanel = parameter as StackPanel;
                var spChildren = stackPanel.Children;
                PasswordBox passwordBox = (PasswordBox)spChildren[1];
                string password = passwordBox.Password;
                Label label = (Label)spChildren[2];

                if (String.IsNullOrEmpty(password) || password.Length < 3)
                {
                    label.Content = "Пароль должен быть не менее 3 символов";
                }
                else label.Content = "";
            }
            else throw new NotImplementedException();
        }
    }
}
