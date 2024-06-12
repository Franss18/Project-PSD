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
    public partial class OrderMakeupPage : System.Web.UI.Page
    {
        //public List<Makeup> items = new List<Makeup>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //items = ItemsController.GetAllMakeups();
            List<Makeup> items = ItemsController.GetAllMakeups();
            GridView1.DataSource = items;
            GridView1.DataBind();


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string quant = quantity.Text;

            if(quant == "")
            {
                LabelValidasi.Text = "Quantity minimal 1";
                LabelValidasi.ForeColor = System.Drawing.Color.Red;
                return;
            }

            int Quantity = Convert.ToInt32(quant);

            if (Quantity < 0)
            {
                LabelValidasi.Text = "Quantity tidak valid";
                LabelValidasi.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else if(Quantity == 0)
            {
                LabelValidasi.Text = "Quantity minimal 1";
                LabelValidasi.ForeColor = System.Drawing.Color.Red;
                return;
            }




        }
    }
}