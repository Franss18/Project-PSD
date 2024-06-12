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
            if (!IsPostBack && Request.Cookies["RememberMe"] != null)
            {
                HttpCookie cookie = Request.Cookies["RememberMe"];
                Tb_Username.Text = cookie.Values["Username"];
                Tb_Password.Attributes["value"] = cookie.Values["Password"];
                rememberMe.Checked = true;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserWebService ws = new UserWebService();
            string username = Tb_Username.Text;
            string password = Tb_Password.Text;

            bool isValidUser = UserController.ValidateUser(username, password);

            if (isValidUser)
            {
                if (rememberMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("RememberMe");
                    cookie.Values["Username"] = username;
                    cookie.Values["Password"] = password;
                    cookie.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(cookie);
                }
                else
                {
                    if (Request.Cookies["RememberMe"] != null)
                    {
                        HttpCookie cookie = new HttpCookie("RememberMe");
                        cookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(cookie);
                    }
                }

                Response.Redirect("HomePage.aspx");
            }
            else
            {
                
            }


        }

        protected void LinkButton_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }
    }
}