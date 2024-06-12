using ProjectPsd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPsd.Repositories
{
    public class UserRepository
    {
        public static List<User> GetAllUsers()
        {
            DatabaseEntities db = DatabaseSingleton.GetSingleton();

            List<User> users = db.Users.ToList();
            return users;
        }

        public static User GetUserByUsername(string username)
        {
            DatabaseEntities db = DatabaseSingleton.GetSingleton();
            User user = (from u in db.Users where u.Username == username select u).ToList().FirstOrDefault();
            return user;
        }

        public static void InsertUser(User user)
        {
            DatabaseEntities db = DatabaseSingleton.GetSingleton();
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static bool ValidateUser(string username, string password)
        {
            DatabaseEntities db = DatabaseSingleton.GetSingleton();
            User user = (from u in db.Users
                         where u.Username == username && u.UserPassword == password
                         select u).FirstOrDefault();
            return user != null;
        }
    }
}