using AOLPROJECTPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.AdminFolder
{
    public partial class OrderDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Response.Cookies["userCookie"] != null)
            {
                if (int.TryParse(Request.Cookies["userCookie"].Value, out int ID))
                {
                    Session["user"] = userController.getUser(ID);
                    Sesi.id = ID;
                    Response.Redirect($"OrderDetail.aspx?id={ID}");
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

            // ambil id transaksi terus tampilin ke labelnya
            int headerId = int.Parse(Request.QueryString["headerid"]);
            int quantity = DetailController.getDetail(headerId).Quantity;
            int ramenPrice = int.Parse(RamenController.getRamen(DetailController.getDetail(headerId).Ramenid).Price);

            Transaction_Id_Label.Text = headerId.ToString();
            Customer_Name_Label.Text = userController.getUser(HeaderController.getHeader(headerId).CustomerId).Username;
            RamenName_Label.Text = RamenController.getRamen(DetailController.getDetail(headerId).Ramenid).Name;
            Price_Total_Label.Text = (quantity * ramenPrice).ToString();
        }
    }
}