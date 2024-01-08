using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Entity;
using System.Collections.ObjectModel;
using StoreWithEF.ViewModel;

namespace StoreWithEF.View
{
    /// <summary>
    /// Interaction logic for ClientsWindow.xaml
    /// </summary>
    public partial class ClientsWindow : Window
    {
        StoreWithEFDBEntities context;

        public ClientsWindow()
        {
            InitializeComponent();
            //context = new StoreWithEFDBEntities();
            DataContext = new ClientsWindowViewModel();
        }

        private void ClientsWindow_Load(object sender, RoutedEventArgs e)
        {
            //ObservableCollection<Clients> observableClients = new ObservableCollection<Clients>(); 
            //var clientsList = context.Clients;
            //foreach(var item in clientsList)
            //{
            //    observableClients.Add(item);
            //}
            //lvClients.ItemsSource = context.Clients.Local.ToBindingList<Clients>();
            //lvClients.ItemsSource = observableClients;
        }
    }
}
