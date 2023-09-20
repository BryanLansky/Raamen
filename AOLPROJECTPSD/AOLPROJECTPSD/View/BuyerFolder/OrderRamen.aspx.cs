using AOLPROJECTPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.BuyerFolder
{
    public partial class OrderRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Response.Cookies["userCookie"] != null)
            {
                if (int.TryParse(Request.Cookies["userCookie"].Value, out int ID))
                {
                    Session["user"] = userController.getUser(ID);
                    BuyerSesi.buyerId = ID;
                    Response.Redirect($"OrderRamen.aspx?buyerid={ID}");
                }
                else
                {
                    Response.Redirect("../login.aspx");
                }
            }
            else if (Session["user"] == null && Response.Cookies["userCookie"] == null)
            {
                Response.Redirect("../login.aspx");
            }

            if (!IsPostBack)
            {
                Ramen_GridView.DataSource = RamenController.getAllRamen();
                Ramen_GridView.DataBind();

                Id_Ramen_TextBox.Text = "";
                Quantity_TextBox.Text = "";
            }
        }

        protected void Add_Button_Click(object sender, EventArgs e)
        {
            // BUTUH TAMBAHAN VAIRABLE CART (LIST) DI DATABASE 
            int buyerId = int.Parse(Request.QueryString["buyerid"]);
            int ramenID = int.Parse(Id_Ramen_TextBox.Text);
            int quantity = int.Parse(Quantity_TextBox.Text);
            // ADD CART
            string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            HeaderController.addCart(buyerId, date, 2); // 2 = cart
            DetailController.addCart(ramenID, quantity, buyerId, 2, date);
            Response.Redirect($"OrderRamen.aspx?buyerid={buyerId}");
        }

        protected void Clear_Button_Click(object sender, EventArgs e)
        {
            int buyerid = int.Parse(Request.QueryString["buyerid"]);
            // DELETE ALL DATA DI CART BY CUSTOMER ID
            HeaderController.deleteCart(buyerid);
            Response.Redirect($"OrderRamen.aspx?buyerid={buyerid}");
        }

        protected void Buy_Button_Click(object sender, EventArgs e)
        {
            int buyerid = int.Parse(Request.QueryString["buyerid"]);
            // ADD UNHANDLED TRANSACTION 
            HeaderController.buyCart(buyerid);
            Response.Redirect($"home_buyer.aspx?buyerid={buyerid}");
        }
    }
}