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

<<<<<<< HEAD
=======
        private bool IsValidInput(string username, string email, string gender, string password, string confirmPassword, DateTime birth)
        {
            bool isValid = true;

            if (username.Length < 5 || username.Length > 15)
            {
                isValid = false;
                validasi.Text = "Username error";
                validasi.ForeColor = System.Drawing.Color.Red;
            }

            if (!email.EndsWith(".com"))
            {
                isValid = false;
                validasi.Text = "Email error";
                validasi.ForeColor = System.Drawing.Color.Red;
            }

            if (string.IsNullOrEmpty(gender))
            {
                isValid = false;
                validasi.Text = "gender error";
                validasi.ForeColor = System.Drawing.Color.Red;
            }

            if (password != confirmPassword || string.IsNullOrEmpty(password))
            {
                isValid = false;
                validasi.Text = "pass error";
                validasi.ForeColor = System.Drawing.Color.Red;
            }

            if (birth == null)
            {
                isValid = false;
                validasi.Text = "DOB error";
                validasi.ForeColor = System.Drawing.Color.Red;
            }

            validasi.Text = "aman";
            validasi.ForeColor = System.Drawing.Color.Green;
            return isValid;
        }

>>>>>>> dc79af38424fc7d7e909bfd316b97389c26c7fd3
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}