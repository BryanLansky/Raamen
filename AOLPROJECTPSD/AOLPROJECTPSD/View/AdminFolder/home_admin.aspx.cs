using AOLPROJECTPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.AdminFolder
{
    public partial class home_admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Response.Cookies["userCookie"] != null)
            {
                if (int.TryParse(Request.Cookies["userCookie"].Value, out int ID))
                {
                    Session["user"] = userController.getUser(ID);
                    Sesi.id = ID;
                    Response.Redirect($"home_admin.aspx?id={ID}");
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

            // buat tampilin gridview
            // customerdataGV.DataSource = ambil list data customer (controller->repo->model)
            // customer.DataBind();
            int id = int.Parse(Request.QueryString["id"]);
            sellerdataGV.DataSource = userController.getAllUserByRole(2); // ambil data seller
            sellerdataGV.DataBind();

            buyerdataGV.DataSource = userController.getAllUserByRole(3); // ambil data buyer
            buyerdataGV.DataBind();
           
        }

    }
}