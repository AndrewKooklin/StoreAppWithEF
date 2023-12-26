using StoreWithEF.Commands;
using StoreWithEF.HelpMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace StoreWithEF.ViewModel
{
    public class RegistrationWindowViewModel : BaseViewModel
    {
        private string _inputLabelContent = "";
        public string InputLabelContent
        {
            get
            {
                return _inputLabelContent;
            }
            set
            {
                _inputLabelContent = value;
                OnPropertyChanged(nameof(InputLabelContent));
            }
        }

        private string _ckeckMatchPasswordsLabelContent = "";
        public string CkeckMatchPasswordsLabelContent
        {
            get
            {
                return _ckeckMatchPasswordsLabelContent;
            }
            set
            {
                _ckeckMatchPasswordsLabelContent = value;
                OnPropertyChanged(nameof(CkeckMatchPasswordsLabelContent));
            }
        }

        public ICommand RedirectToLogInCommand { get; set; }

        public ICommand RegisterCommand { get; set; }

        public RegistrationWindowViewModel()
        {
            RedirectToLogInCommand = new RedirectToLogInCommand();
            RegisterCommand = new RelayCommand(Execute, CanExecute);
        }

        private bool CanExecute(object param)
        {
            if (param == null)
            {
                return false;
            }
            var values = (object[])param;
            string userName = values[0].ToString();
            PasswordBox passwordBox = (PasswordBox)values[1];
            string passwordValue = passwordBox.Password;

            if (userName == null || String.IsNullOrEmpty(userName) || String.IsNullOrWhiteSpace(UserName) ||
                userName.Length < 3 || passwordValue.Length < 3 ||
                String.IsNullOrWhiteSpace(passwordValue) || String.IsNullOrEmpty(passwordValue))
            {
                InputLabelContent = "Имя и пароль не менее 3 символов";
                CheckUserLabelContent = "";
                return false;
            }
            else
            {
                InputLabelContent = "";
                return true;
            }
        }

        private void Execute(object param)
        {
            if (param == null)
            {
                return;
            }
            var values = (object[])param;
            string userNameValue = values[0].ToString();
            PasswordBox passwordBox = (PasswordBox)values[1];
            string passwordValue = passwordBox.Password;

            CheckUserToDataBase checkUserToDB = new CheckUserToDataBase();

            if (!checkUserToDB.CheckUser(userNameValue, passwordValue))
            {
                CheckUserLabelContent = "Пользователь не найден,\nпроверьте имя и пароль";
                return;
            }
            else
            {
                CheckUserLabelContent = "";
                App.Current.MainWindow.Hide();
                ClientsWindow clientsWindow = new ClientsWindow();
                clientsWindow.Show();
            }
        }
    }
}
