using ProjectPsd_Frontend.Controllers;
using ProjectPsd_Frontend.Models;
using ProjectPsd_Frontend.UserWebReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPsd_Frontend.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null || Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("~/Views/HomePage.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DatabaseEntities db = new DatabaseEntities();
            string username = Tb_Username.Text;
            string password = Tb_Password.Text;
            Boolean isRememberMe = rememberMe.Checked;

            User user = db.Users.Where(u => u.Username == username && u.UserPassword == password).FirstOrDefault();

            if (isRememberMe)
            {
                HttpCookie cookie = Request.Cookies["user_cookie"];
                Tb_Username.Text = cookie.Values["Username"];
                cookie.Expires = DateTime.Now.AddHours(1);

            }
            
            Session["user"] = user;
            Response.Redirect("HomePage.aspx");
        }

        protected void LinkButton_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }
    }
}