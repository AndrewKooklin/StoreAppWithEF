using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StoreWithEF.ViewModel
{
    public class ClientsWindowViewModel
    {
        StoreWithEFDBEntities context = new StoreWithEFDBEntities();

        public ClientsWindowViewModel()
        {
            context.Clients.Load();


        }
    }
}
