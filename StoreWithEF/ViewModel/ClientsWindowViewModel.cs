using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Input;
using StoreWithEF.Commands;

namespace StoreWithEF.ViewModel
{
    public class ClientsWindowViewModel : BaseViewModel
    {
        StoreWithEFDBEntities context = new StoreWithEFDBEntities();

        public ClientsWindowViewModel()
        {
            context.Clients.Load();

            OpenFormAddClientCommand = new OpenFormAddClientWindowCommand();
        }

        public ICommand OpenFormAddClientCommand { get; set; }
    }
}
