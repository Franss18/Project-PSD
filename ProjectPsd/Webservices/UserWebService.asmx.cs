using ProjectPsd.Handlers;
using ProjectPsd.Models;
using ProjectPsd.Modules;
using ProjectPsd.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProjectPsd.Webservices
{
    /// <summary>
    /// Summary description for UserWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetAllUsers()
        {
            List<User> users = UserHandler.GetAllUsers();
            string json = Json.Encode(users);
            return json;
        }

        [WebMethod]
        public string InsertUser(string username, string email, string gender, string password, DateTime birth)
        {
            bool isSuccess = UserHandler.InsertUser(username, email, gender, password, birth);
            string json = Json.Encode(isSuccess);
            return json;
        }

        [WebMethod]
        public string ValidateUser(string username, string password)
        {
            bool isSuccess = UserHandler.ValidateUser(username, password);
            string json = Json.Encode(isSuccess);
            return json;
        }
    }
}
