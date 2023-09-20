using AOLPROJECTPSD.Controller;
using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.SellerFolder
{
    public partial class UpdateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Response.Cookies["userCookie"] != null)
            {
                if (int.TryParse(Request.Cookies["userCookie"].Value, out int ID))
                {
                    Session["user"] = userController.getUser(ID);
                    SellerSesi.SellerId = ID;
                    Response.Redirect($"UpdateRamen.aspx?sellerid={ID}");
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

            //ambil all data customer terus tampilin
            if (!IsPostBack)
            {
                // ambil data ramennya dari controller terus tampilin
                int ramenid = int.Parse(Request.QueryString["ramenid"]);
                Raman ramen = RamenController.getRamen(ramenid);
                Name_Label.Text = ramen.Name;
                Meat_Label.Text = RamenController.getMeat(ramen.Meatid).name;
                Broth_Label.Text = ramen.Broth;
                Price_Label.Text = ramen.Price;

                Name_Textbox.Text = "";
                Meat_Textbox.Text = "";
                Broth_Textbox.Text = "";
                Price_Textbox.Text = "";
            }
        }

        protected void Update_Button_Click(object sender, EventArgs e)
        {
            // controller update data ramen
            string name = Name_Textbox.Text;
            string meat = Meat_Textbox.Text;
            string broth = Broth_Textbox.Text;
            string price = Price_Textbox.Text;
            //controller buat update 
            statusLbl.Text = RamenController.updateRamen(int.Parse(Request.QueryString["ramenid"]), int.Parse(meat), name, broth, price);
            Response.Redirect($"UpdateRamen.aspx?sellerid={int.Parse(Request.QueryString["sellerid"])}&ramenid={int.Parse(Request.QueryString["ramenid"])}");
        }

        protected void Back_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect($"ManageRamen.aspx?sellerid={int.Parse(Request.QueryString["sellerid"])}");
        }

        protected void Delete_Button_Click(object sender, EventArgs e)
        {
            //controller delete ramen
            RamenController.deleteRamen(int.Parse(Request.QueryString["ramenid"]));
            Response.Redirect($"ManageRamen.aspx?sellerid={int.Parse(Request.QueryString["sellerid"])}");
        }
    }
}