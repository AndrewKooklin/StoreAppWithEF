using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace StoreWithEF.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {

        public ICommand LogInCommand { get; set; }

        
        public void ValidateText_UserName(object sender, TextChangedEventArgs e)
        {
            
        }

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
