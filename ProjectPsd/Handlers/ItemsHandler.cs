using ProjectPsd.Models;
using ProjectPsd.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPsd.Handlers
{
    public class ItemsHandler
    {
        public static List<Makeup> GetAllMakeups()
        {
            List<Makeup> items = ItemsRepository.GetAllMakeups();
            return items;
        }

    }
}