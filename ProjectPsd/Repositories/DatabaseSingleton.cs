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
        private static readonly object padlock = new object();
        private static int currentId = 0;

        public static DatabaseEntities GetSingleton()
        {
            if (db == null)
            {
                lock (padlock)
                {
                    if (db == null)
                    {
                        db = new DatabaseEntities();
                        InitializeCurrentId();
                    }
                }
            }
            return db;
        }

        private static void InitializeCurrentId()
        {
            currentId = db.Users.Select(u => (int?)u.UserID).Max() ?? 0;
        }

        public static int GetNextId()
        {
            lock (padlock)
            {
                return ++currentId;
            }
        }
    }
}