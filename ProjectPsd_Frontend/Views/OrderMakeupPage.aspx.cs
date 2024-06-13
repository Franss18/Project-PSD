using ProjectPsd_Frontend.Controllers;
using ProjectPsd_Frontend.Models;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPsd_Frontend.Views
{
    public partial class OrderMakeupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Makeup> items = ItemController.GetAllMakeups();
                GridView.DataSource = items;
                GridView.DataBind();
            }
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateAndAddToCart();
        }

        protected void GridView3_SelectedIndexChanged1(object sender, EventArgs e)
        {
            ValidateAndAddToCart();
        }

        private void ValidateAndAddToCart()
        {
            string quant = quantity.Text;

            if (string.IsNullOrWhiteSpace(quant))
            {
                LabelValidasi.Text = "Quantity minimal 1";
                LabelValidasi.ForeColor = System.Drawing.Color.Red;
                return;
            }

            int Quantity;
            if (!int.TryParse(quant, out Quantity) || Quantity <= 0)
            {
                LabelValidasi.Text = Quantity < 0 ? "Quantity tidak valid" : "Quantity minimal 1";
                LabelValidasi.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Make sure a row is selected
            if (GridView.SelectedIndex == -1)
            {
                LabelValidasi.Text = "Please select an item";
                LabelValidasi.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Get the selected makeup ID from the GridView's DataKey
            int makeupId = Convert.ToInt32(GridView.DataKeys[GridView.SelectedIndex].Value);

            // Assuming userId is retrieved from session or some other context
            int userId = GetUserId(); // Implement this method to retrieve the user ID

            bool inputCartSuccess = ItemController.InputCart(userId, makeupId, Quantity);

            if (inputCartSuccess)
            {
                LabelValidasi.Text = "Item berhasil ditambahkan ke Cart";
                LabelValidasi.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                LabelValidasi.Text = "Failed to add item to cart";
                LabelValidasi.ForeColor = System.Drawing.Color.Red;
            }
        }

        private int GetUserId()
        {
            // Implement the logic to get the user ID, for example, from the session
            // return Convert.ToInt32(Session["UserId"]);
            return 1; // Placeholder for demonstration purposes
        }
    }
}
