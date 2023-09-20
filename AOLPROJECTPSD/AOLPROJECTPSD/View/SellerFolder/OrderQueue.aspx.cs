using AOLPROJECTPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.SellerFolder
{
    public partial class OrderQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Response.Cookies["userCookie"] != null)
            {
                if (int.TryParse(Request.Cookies["userCookie"].Value, out int ID))
                {
                    Session["user"] = userController.getUser(ID);
                    SellerSesi.SellerId = ID;
                    Response.Redirect($"OrderQueue.aspx?sellerid={ID}");
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

            // AMBIL ALL DATA TRANS HANDLE/UNHANDLE DARI DB CART
            if (!IsPostBack)
            {
                Transaction_Done_Gridview.DataSource = HeaderController.getAllHeaderDone();
                Transaction_Done_Gridview.DataBind();

                Transaction_Unhandled_Gridview.DataSource = HeaderController.getAllHeaderUnhandled();
                Transaction_Unhandled_Gridview.DataBind();

                unhandled_Transaction_id_Textbox.Text = "";
            }
        }

        protected void Handle_Button_Click(object sender, EventArgs e)
        {
            // cari id di atas terus kalo ketemu ubah status menjadi handle, kalo ga nemu bilang wrong input
            string id_unhandled = unhandled_Transaction_id_Textbox.Text;
            // cari dulu id nya abis itu ubah status unhandle ke handle
            HeaderController.updateStatusHeaderDone(int.Parse(id_unhandled));
            Response.Redirect($"OrderQueue.aspx?id={SellerSesi.SellerId}");
        }
    }
}