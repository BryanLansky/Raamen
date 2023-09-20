using AOLPROJECTPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.SellerFolder
{
    public partial class ManageRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Response.Cookies["userCookie"] != null)
            {
                if (int.TryParse(Request.Cookies["userCookie"].Value, out int ID))
                {
                    Session["user"] = userController.getUser(ID);
                    SellerSesi.SellerId = ID;
                    Response.Redirect($"ManageRamen.aspx?sellerid={ID}");
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

            // ambil all data ramen
            //Ramen_Gridview.DataSource = ;
            //Ramen_Gridview.DataBind();
            Ramen_Gridview.DataSource = RamenController.getAllRamen();
            Ramen_Gridview.DataBind();
        }

        protected void Update_Button_Click(object sender, EventArgs e)
        {
            int sellerid = int.Parse(Request.QueryString["sellerid"]);
            Response.Redirect($"UpdateRamen.aspx?sellerid={sellerid}&ramenid={int.Parse(ramenid_textbox.Text)}");
        }

        protected void Insert_Button_Click(object sender, EventArgs e)
        {
            int sellerid = int.Parse(Request.QueryString["sellerid"]);
            Response.Redirect($"InsertRamen.aspx?sellerid={sellerid}");
        }
    }
}