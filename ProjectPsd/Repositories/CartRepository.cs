using ProjectPsd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPsd.Repositories
{
    public class CartRepository
    {
        public static void AddItem(int userId, int makeupId, int quantity)
        {
            // Implement the logic to add the item to the cart in the database
            // For example:
            //using (var context = new YourDbContext())
            //{
            //    var cartItem = new CartItem
            //    {
            //        UserId = userId,
            //        MakeupId = makeupId,
            //        Quantity = quantity,
            //        DateAdded = DateTime.Now
            //    };
            //    context.CartItems.Add(cartItem);
            //  context.SaveChanges();
            //}
        }
    }
}