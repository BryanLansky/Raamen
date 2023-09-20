using AOLPROJECTPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.SellerFolder
{
    public partial class home_seller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Response.Cookies["userCookie"] != null)
            {
                if (int.TryParse(Request.Cookies["userCookie"].Value, out int ID))
                {
                    Session["user"] = userController.getUser(ID);
                    SellerSesi.SellerId = ID;
                    Response.Redirect($"home_seller.aspx?sellerid={ID}");
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

            // ambil all data customer
            //customerdataGV.DataSource = ... ; 
            //customer.DataBind();
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["sellerid"]);
                customerdataGV.DataSource = userController.getAllUserByRole(3); // ambil data buyer
                customerdataGV.DataBind();
            }
        }


    }
}