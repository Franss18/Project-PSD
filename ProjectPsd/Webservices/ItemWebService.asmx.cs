using ProjectPsd.Handlers;
using ProjectPsd.Models;
using ProjectPsd.Modules;
using ProjectPsd.Repositories;
using System;
using System.Collections.Generic;
using System.Web.Services;

namespace ProjectPsd.Webservices
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class ItemWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public string GetAllMakeups()
        {
            List<Makeup> items = ItemsHandler.GetAllMakeups();
            string json = Json.Encode(items);
            return json;
        }

        [WebMethod]
        public bool AddToCart(int userId, int makeupId, int quantity)
        {
            // Implement logic to add item to cart
            return CartHandler.AddItemToCart(userId, makeupId, quantity);
        }
    }
}
