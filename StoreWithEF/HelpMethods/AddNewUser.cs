﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithEF.HelpMethods
{
    public class AddNewUser
    {
        GetDBContext getDBContext = new GetDBContext();
        
        public void Add(Users user)
        {
            var db = getDBContext.GetDB();
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}
