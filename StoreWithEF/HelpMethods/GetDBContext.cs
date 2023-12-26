using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithEF.HelpMethods
{
    /// <summary>
    /// Получение контекста базы данных
    /// </summary>
    public class GetDBContext
    {
        public StoreWithEFDBEntities GetDB()
        {
            StoreWithEFDBEntities storeWithEFDBEntities = new StoreWithEFDBEntities();

            return storeWithEFDBEntities;
        }
    }
}
