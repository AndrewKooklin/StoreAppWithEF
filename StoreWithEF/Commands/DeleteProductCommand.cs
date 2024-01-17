using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StoreWithEF.Commands
{
    public class DeleteProductCommand : ICommand
    {
        ObservableCollection<Products> _observableProducts;
        ListView listView;
        StoreWithEFDBEntities _context;
        public event EventHandler CanExecuteChanged;

        public DeleteProductCommand(ObservableCollection<Products> observableProducts, StoreWithEFDBEntities context)
        {
            _observableProducts = observableProducts;
            _context = context;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ListView)
            {
                listView = (ListView)parameter;
            }
            else
            {
                return;
            }

            int indexView = listView.SelectedIndex;
            if (indexView == -1 || indexView > (listView.Items.Count - 1))
            {
                MessageBox.Show("Выберите клиента из списка", "Выбор клиента",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Products product = (Products)listView.SelectedItem;
            _context.Products.Remove(product);
            //foreach (var item in _context.Products)
            //{
            //    if (item.Equals(product))
            //    {
            //        _context.Products.Remove(product);
            //    }
            //}
            _context.SaveChanges();
            _observableProducts.Remove(product);
            App.productsWindow.lvProducts.ItemsSource = null;
            App.productsWindow.lvProducts.ItemsSource = _observableProducts;
        }
    }
}
