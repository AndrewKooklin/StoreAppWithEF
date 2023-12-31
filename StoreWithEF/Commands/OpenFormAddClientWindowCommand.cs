﻿using StoreWithEF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StoreWithEF.Commands
{
    public class OpenFormAddClientWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            AddClientWindow addClientWindow = new AddClientWindow();
            addClientWindow.Show();
        }
    }
}
