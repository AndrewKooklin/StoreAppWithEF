﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithEF.HelpMethods
{
    public class AddNewClient
    {
        GetDBContext getDBContext = new GetDBContext();

        public void AddClient(Clients client)
        {
            var db = getDBContext.GetDB();
            db.Clients.Add(client);
            db.SaveChanges();
        }
    }
}
