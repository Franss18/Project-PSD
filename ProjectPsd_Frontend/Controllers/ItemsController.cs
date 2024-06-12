using ProjectPsd_Frontend.ItemsWebReference;
using ProjectPsd_Frontend.Models;
using ProjectPsd_Frontend.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPsd_Frontend.Controllers
{
    public class ItemsController
    {
        public static List<Makeup> GetAllMakeups()
        {
            ItemWebService ws = new ItemWebService();
            string json = ws.GetAllMakeups();
            return Json.Decode<List<Makeup>>(json);
        }
    }
}