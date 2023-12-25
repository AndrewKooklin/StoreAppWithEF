using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.ComponentModel;
using StoreWithEF.Commands;

namespace StoreWithEF.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string userName;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

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

        private string _ckeckUserLabelContent = "";
        public string CheckUserLabelContent
        {
            get
            {
                return _ckeckUserLabelContent;
            }
            set
            {
                _ckeckUserLabelContent = value;
                OnPropertyChanged(nameof(CheckUserLabelContent));
            }
        }

        public MainWindowViewModel()
        {
            LogInCommand = new RelayCommand(Execute, CanExecute);
        }

        public ICommand LogInCommand { get; set; }


        private bool CanExecute(object param)
        {
            if(param == null)
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
            // TODO CheckUserToDataBase(param);
        }


        public ICommand RegistrationRedirectCommand { get; set; }
    }
}
