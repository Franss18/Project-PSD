using ProjectPsd_Frontend.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPsd_Frontend.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox_Username.Text;
            string email = TextBox_Email.Text;
            string gender = GetSelectedGender();
            string password = TextBox_Password.Text;
            DateTime birth = Calendar_dob.SelectedDate;

            if (!IsValidInput(username, email, gender, password, confirmPassword, birth))
            {
                return;
            }

            bool isSuccess = UserController.InsertUser(username, email, gender, password, birth);

            if (isSuccess)
            {
                UserController.AssignRole(username, "customer");
                Response.Redirect("HomePage.aspx");
            }
        }

        private string GetSelectedGender()
        {
            if (CheckBox_Male.Checked)
            {
                return "Male";
            }
            else if (CheckBox_Female.Checked)
            {
                return "Female";
            }
            else
            {
                return string.Empty;
            }
        }

        private bool IsValidInput(string username, string email, string gender, string password, string confirmPassword, DateTime birth)
        {
            bool isValid = true;

            // Username validation
            if (username.Length < 5 || username.Length > 15)
            {
                isValid = false;
                // Display error message
            }

            // Email validation
            if (!email.EndsWith(".com"))
            {
                isValid = false;
                // Display error message
            }

            // Gender validation
            if (string.IsNullOrEmpty(gender))
            {
                isValid = false;
                // Display error message
            }

            // Password validation
            if (password != confirmPassword || string.IsNullOrEmpty(password))
            {
                isValid = false;
                // Display error message
            }

            // Date of Birth validation
            if (birth == DateTime.MinValue)
            {
                isValid = false;
                // Display error message
            }

            return isValid;
        }
    }
}