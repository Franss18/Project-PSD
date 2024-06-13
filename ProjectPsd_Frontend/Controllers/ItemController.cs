using ProjectPsd_Frontend.Models;
using ProjectPsd_Frontend.ItemWebReference;
using System.Collections.Generic;
using ProjectPsd_Frontend.Modules;

namespace ProjectPsd_Frontend.Controllers
{
    public class ItemController
    {
        public static List<Makeup> GetAllMakeups()
        {
            ItemWebService ws = new ItemWebService();
            string json = ws.GetAllMakeups();
            return Json.Decode<List<Makeup>>(json);
        }

        public static bool InputCart(int userId, int makeupId, int quantity)
        {
            ItemWebService ws = new ItemWebService();
            return ws.AddToCart(userId, makeupId, quantity);
        }
    }
}
