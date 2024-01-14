using StoreWithEF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StoreWithEF.Commands
{
    public class OpenFormAddClientWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        ListView listView;
        int _clientId;

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

            //int indexView = listView.SelectedIndex;
            //if (indexView == -1 || indexView > (listView.Items.Count - 1))
            //{
            //    MessageBox.Show("Выберите клиента из списка", "Выбор клиента",
            //        MessageBoxButton.OK, MessageBoxImage.Warning);
            //    return;
            //}

            AddClientWindow addClientWindow = new AddClientWindow();

            

            
            addClientWindow.Show();
        }
    }
}
