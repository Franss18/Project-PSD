using ProjectPsd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProjectPsd.Repositories
{
    public class ItemsRepository
    {

        public static List<Makeup> GetAllMakeups()
        {
            DatabaseEntities db = DatabaseSingleton.GetSingleton();

            List<Makeup> items = db.Makeups.ToList();

            return items;
        }
    }
}