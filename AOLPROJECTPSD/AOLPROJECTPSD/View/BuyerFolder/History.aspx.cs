using AOLPROJECTPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.BuyerFolder
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Response.Cookies["userCookie"] != null)
            {
                if (int.TryParse(Request.Cookies["userCookie"].Value, out int ID))
                {
                    Session["user"] = userController.getUser(ID);
                    BuyerSesi.buyerId = ID;
                    Response.Redirect($"History.aspx?buyerid={ID}");
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
                int buyerid = int.Parse(Request.QueryString["buyerid"]);
                Transaction_GridView.DataSource = HeaderController.getAllHeaderDoneByCustomerId(buyerid);
                Transaction_GridView.DataBind();

                TransactionId_TextBox.Text = "";
            }
        }

        protected void CheckTransaction_Button_Click(object sender, EventArgs e)
        {
            string transactionID = TransactionId_TextBox.Text;
            // kalo ketemu langsung Response.Redirect("OrderDetail.aspx"); terus kasih transactionID
        }
    }
}