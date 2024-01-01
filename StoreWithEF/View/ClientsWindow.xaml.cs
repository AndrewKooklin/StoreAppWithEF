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
            context = new StoreWithEFDBEntities(); 
        }

        private void ClientsWindow_Load(object sender, RoutedEventArgs e)
        {
            context.Clients.Load();
            lvClients.ItemsSource = context.Clients.Local.ToBindingList<Clients>();

        }
    }
}
