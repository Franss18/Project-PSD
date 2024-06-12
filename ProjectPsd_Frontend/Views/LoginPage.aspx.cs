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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserWebService ws = new UserWebService();
            string username = Tb_Username.Text;
            string password = Tb_Password.Text;

            User user = ws.GetAllUsers.Where(u => u.Username == username)
        }
    }
}