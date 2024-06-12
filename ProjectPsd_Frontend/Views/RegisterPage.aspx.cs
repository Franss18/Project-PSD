using ProjectPsd_Frontend.Controllers;
using ProjectPsd_Frontend.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPsd_Frontend.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        private static readonly object padlock = new object();
        DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox_Username.Text;
            string email = TextBox_Email.Text;
            string gender = GetSelectedGender();
            string password = TextBox_Password.Text;
            DateTime birth = Calendar_dob.SelectedDate.Date;

            bool isSuccess = UserController.InsertUser(username, email, gender, password, birth);
            
            if (isSuccess)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                ErrorMessageLabel.Text = "User insertion failed. Please ensure the username is unique and try again.";
                ErrorMessageLabel.Visible = true;
            }
        }

        private string GetSelectedGender()
        {
            if (RadioButton_Male.Checked)
            {
                return "Male";
            }
            else if (RadioButton_Female.Checked)
            {
                return "Female";
            }
            else
            {
                return string.Empty;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}