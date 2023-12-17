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

namespace StoreWithEF.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {

        public ICommand LogInCommand { get; set; }


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


        

        public ICommand RegistrationRedirectCommand { get; set; }

        

        public MainWindowViewModel()
        {


        }    
    }
}
