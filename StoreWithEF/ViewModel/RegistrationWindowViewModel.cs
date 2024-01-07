﻿using StoreWithEF.Commands;
using StoreWithEF.HelpMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        private bool _ckeckRememberMe = false;
        public bool CkeckRememberMe
        {
            get
            {
                return _ckeckRememberMe;
            }
            set
            {
                if(_ckeckRememberMe != value)
                {
                    _ckeckRememberMe = false;
                }
                if(_ckeckRememberMe == value)
                {
                    return;
                }
                _ckeckRememberMe = value;
                OnPropertyChanged(nameof(CkeckRememberMe));
            }
        }

        //private void Checked(object sender, RoutedEventArgs e)
        //{
        //    _ckeckRememberMe = true;
        //}

        //private void UnChecked(object sender, RoutedEventArgs e)
        //{
        //    _ckeckRememberMe = false;
        //}

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
            PasswordBox confirmPassword = (PasswordBox)values[2];
            string confirmPasswordValue = confirmPassword.Password;
            

            if (userName == null || String.IsNullOrEmpty(userName) || String.IsNullOrWhiteSpace(userName) ||
                userName.Length < 3 || passwordValue.Length < 3 ||
                String.IsNullOrWhiteSpace(passwordValue) || String.IsNullOrEmpty(passwordValue))
            {
                InputLabelContent = "Имя и пароль не менее 3 символов !";
                CkeckMatchPasswordsLabelContent = "";
                return false;
            }
            if (!passwordValue.Equals(confirmPasswordValue))
            {
                CkeckMatchPasswordsLabelContent = "Пароли не совпадают !";
                return false;
            }
            else
            {
                InputLabelContent = "";
                CkeckMatchPasswordsLabelContent = "";
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
            PasswordBox confirmPassword = (PasswordBox)values[2];
            string confirmPasswordValue = confirmPassword.Password;

            CheckUserToDataBase checkUserToDB = new CheckUserToDataBase();

            if (checkUserToDB.CheckUser(userNameValue, passwordValue))
            {
                //CkeckMatchPasswordsLabelContent = "Пользователь уже существует !";
                MessageBox.Show("Пользователь уже существует", "Registration", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (!passwordValue.Equals(confirmPasswordValue))
            {
                CkeckMatchPasswordsLabelContent = "Пароли не совпадают !";
                return;
            }
            else
            {
                Users user = new Users(userNameValue, passwordValue);
                AddNewUser addUser = new AddNewUser();
                addUser.Add(user);

                if (CkeckRememberMe)
                {
                    StoreWithEF.Properties.Settings.Default.UserName = userNameValue;
                    StoreWithEF.Properties.Settings.Default.Password = passwordValue;
                    StoreWithEF.Properties.Settings.Default.Save();
                }
                CkeckMatchPasswordsLabelContent = "";
                MessageBox.Show("Вы успешно зарегистрировались", "Registration", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
