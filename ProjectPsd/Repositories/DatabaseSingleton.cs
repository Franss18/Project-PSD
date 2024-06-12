using ProjectPsd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPsd.Repositories
{
    public class DatabaseSingleton
    {
        private static DatabaseEntities db = null;

        public static DatabaseEntities GetSingleton()
        {
            if (db == null)
            {
                db = new DatabaseEntities();
            }
            return db;
        }
    }
}