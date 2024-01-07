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
        public AddClientWindowViewModel()
        {
            AddClientCommand = new AddClientCommand();
        }

        public ICommand AddClientCommand { get; set; }
    }
}
