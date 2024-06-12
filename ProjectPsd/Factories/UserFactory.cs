using ProjectPsd.Models;
using ProjectPsd.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPsd.Factories
{
    public class UserFactory
    {
        public static User CreateUser(string username, string email, string gender, string password, DateTime birth)
        {
            User newUser = new User()
            {
                Username = username,
                UserEmail = email,
                UserDOB = birth,
                UserGender = gender,
                UserRole = "Customer",
                UserPassword = password
                
            };
            return newUser;
        }
    }
}