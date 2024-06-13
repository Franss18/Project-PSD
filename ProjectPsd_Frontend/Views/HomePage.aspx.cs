using ProjectPsd_Frontend.Controllers;
using ProjectPsd_Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPsd_Frontend.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/LoginPage.aspx");
            }

            if (Request.Cookies["user_cookie"] != null)
            {
                DatabaseEntities db = new DatabaseEntities();
                var userId = Request.Cookies["user_cookie"].Value;
                User user = db.Users.Where(u => u.Username == userId).FirstOrDefault();

                if (user == null)
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }

                Session["user"] = user;
            }

            if (Session["user"] != null)
            {
                DatabaseEntities db = new DatabaseEntities();
                //string username;
                //string role;
                User user = db.Users.Where(u => u.Username == u.Username && u.UserRole == u.UserRole).FirstOrDefault();
                LblUserInfo.Text = $"Welcome, {user.UserID}. Your role is {user.UserRole}.";

                if (user.UserRole == "Admin")
                {
                    List<User> users = UserController.GetAllUsers();
                    GridView1.DataSource = users;
                    GridView1.DataBind();
                }
            }
        }
    }
}