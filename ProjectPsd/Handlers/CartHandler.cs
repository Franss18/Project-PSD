using ProjectPsd.Models;
using ProjectPsd.Repositories;
using System;

namespace ProjectPsd.Handlers
{
    public class CartHandler
    {
        public static bool AddItemToCart(int userId, int makeupId, int quantity)
        {
            try
            {
                // Assuming you have a repository for handling cart operations
                CartRepository.AddItem(userId, makeupId, quantity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
