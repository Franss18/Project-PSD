using ProjectPsd_Frontend.Models;
using ProjectPsd_Frontend.Modules;
using ProjectPsd_Frontend.UserWebReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPsd_Frontend.Controllers
{
    public class UserController
    {

        public static List<User> GetAllUsers()
        {
            UserWebService ws = new UserWebService();
            string json = ws.GetAllUsers();
            return Json.Decode<List<User>>(json);
        }

        public static bool InsertUser(string username, string email, string gender, string password, DateTime birth)
        {
            UserWebService ws = new UserWebService();
            string json = ws.InsertUser(username, email, gender, password, birth);
            return Json.Decode<bool>(json);

        }

        public static bool ValidateUser(string username, string password)
        {
            UserWebService ws = new UserWebService();
            string json = ws.ValidateUser(username, password);
            return Json.Decode<bool>(json);

        }
    }
}