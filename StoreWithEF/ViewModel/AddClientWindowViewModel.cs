using StoreWithEF.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StoreWithEF.ViewModel
{
    public class AddClientWindowViewModel : BaseViewModel
    {
        ClientsWindowViewModel clientsWindowViewModel = new ClientsWindowViewModel();


        public AddClientWindowViewModel()
        {
            AddClientCommand = new AddClientCommand(clientsWindowViewModel);
        }

        public ICommand AddClientCommand { get; set; }
    }
}
