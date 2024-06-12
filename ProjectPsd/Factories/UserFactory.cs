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
                UserID = DatabaseSingleton.GetNextId(),
                Username = username,
                UserEmail = email,
                UserGender = gender,
                UserPassword = password,
                UserDOB = birth.Date,
                UserRole = "Customer"

            };
            return newUser;
        }
    }
}