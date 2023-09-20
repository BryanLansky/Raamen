using AOLPROJECTPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.AdminFolder
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
                    Sesi.id = ID;
                    Response.Redirect($"ManageRamen.aspx?id={ID}");
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

            Ramen_Gridview.DataSource = RamenController.getAllRamen();
            Ramen_Gridview.DataBind();
        }

        protected void Update_Button_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            Response.Redirect($"UpdateRamen.aspx?id={id}&ramenid={int.Parse(idramenTextbox.Text)}");
        }

        protected void Insert_Button_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            Response.Redirect($"InsertRamen.aspx?id={id}");
        }
    }
}