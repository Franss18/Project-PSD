using ProjectPsd.Factories;
using ProjectPsd.Models;
using ProjectPsd.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ProjectPsd.Handlers
{
    public class UserHandler
    {
        public static List<User> GetAllUsers()
        {
            List<User> users = UserRepository.GetAllUsers();
            return users;
        }

        public static bool InsertUser(string username, string email, string gender, string password, DateTime birth)
        {
                User newUser = UserFactory.CreateUser(username, email, gender, password, birth);
                UserRepository.InsertUser(newUser);
                return true; 
        }

        public static bool ValidateUser(string username, string password) 
        {
            return UserRepository.ValidateUser(username, password);
        }
    }
}