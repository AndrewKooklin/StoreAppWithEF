using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Input;
using StoreWithEF.Commands;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections;

namespace StoreWithEF.ViewModel
{
    public class ClientsWindowViewModel : BaseViewModel
    {
        StoreWithEFDBEntities context = new StoreWithEFDBEntities();

        public ClientsWindowViewModel()
        {
            _observableClients = new ObservableCollection<Clients>();
            context.Clients.Load();
            OpenFormAddClientCommand = new OpenFormAddClientWindowCommand();
            AddClientCommand = new AddClientCommand(ObservableClients, context);
            DeleteClientCommand = new DeleteClientCommand(ObservableClients, context);
            CloseWindowCommand = new CloseWindowCommand();
            
            foreach (var item in context.Clients)
            {
                _observableClients.Add(item);
            }
        }

        public ICommand OpenFormAddClientCommand { get; set; }

        public ICommand AddClientCommand { get; set; }

        public ICommand DeleteClientCommand { get; set; }

        public ICommand CloseWindowCommand { get; set; }

        private ObservableCollection<Clients> _observableClients;

        public ObservableCollection<Clients> ObservableClients
        {
            get
            {
                return _observableClients;
            }
            set
            {
                _observableClients = value;
                OnPropertyChanged(nameof(ObservableClients));
            }
        }
    }
}
