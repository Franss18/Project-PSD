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
            string confirmPassword = TextBox_Confirmation.Text;
            DateTime birth = Calendar_dob.SelectedDate;

            if (!IsValidInput(username, email, gender, password, confirmPassword, birth))
            {
                return;
            }

            bool isSuccess = UserController.InsertUser(username, email, gender, password, birth);

            if (isSuccess)
            {
                Response.Redirect("LoginPage.aspx");
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

            if (username.Length < 5 || username.Length > 15)
            {
                isValid = false;
            }

            if (!email.EndsWith(".com"))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(gender))
            {
                isValid = false;
            }

            if (password != confirmPassword || string.IsNullOrEmpty(password))
            {
                isValid = false;
            }

            if (birth == DateTime.MinValue)
            {
                isValid = false;
            }

            return isValid;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}