using AOLPROJECTPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.AdminFolder
{
    public partial class InsertRamen : System.Web.UI.Page
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

            if (!IsPostBack)
            {
                Name_Textbox.Text = "";
                Meat_Textbox.Text = "";
                Broth_Textbox.Text = "";
                Price_Textbox.Text = "";
            }
        }

        protected void Insert_Button_Click(object sender, EventArgs e)
        {
            String name = Name_Textbox.Text;
            String meat = Meat_Textbox.Text;
            String broth = Broth_Textbox.Text;
            String price = Price_Textbox.Text;

            // pake controller buat insert semua field di atas
            statusLbl.Text = RamenController.createRamen(meat, name, broth, price);
            int id = int.Parse(Request.QueryString["id"]);
            Response.Redirect($"ManageRamen.aspx?id={id}");
        }

        protected void Back_Button_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            Response.Redirect($"ManageRamen.aspx?id={id}");
        }
    }
}