using AOLPROJECTPSD.Controller;
using AOLPROJECTPSD.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.SellerFolder
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Response.Cookies["userCookie"] != null)
            {
                if (int.TryParse(Request.Cookies["userCookie"].Value, out int ID))
                {
                    Session["user"] = userController.getUser(ID);
                    SellerSesi.SellerId = ID;
                    Response.Redirect($"Profile.aspx?sellerid={ID}");
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

            // ambil data user terus tampilin
            int buyerid = int.Parse(Request.QueryString["sellerid"]);
            Username_Label.Text = userHandler.getUser(buyerid).Username;
            Email_Label.Text = userHandler.getUser(buyerid).Email;
            Gender_Label.Text = userHandler.getUser(buyerid).Gender;
            Password_Label.Text = userHandler.getUser(buyerid).Password;
        }

        protected void Update_Button_Click(object sender, EventArgs e)
        {
            int buyerid = int.Parse(Request.QueryString["sellerid"]);
            Response.Redirect($"UpdateProfile.aspx?sellerid={buyerid}");
        }
    }
}