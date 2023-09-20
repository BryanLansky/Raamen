using AOLPROJECTPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.BuyerFolder
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Response.Cookies["userCookie"] != null)
            {
                if (int.TryParse(Request.Cookies["userCookie"].Value, out int ID))
                {
                    Session["user"] = userController.getUser(ID);
                    BuyerSesi.buyerId = ID;
                    Response.Redirect($"UpdateProfile.aspx?buyerid={ID}");
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
                Username_TextBox.Text = "";
                Email_TextBox.Text = "";
                Gender_TextBox.Text = "";
                Password_TextBox.Text = "";
            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            string username = Username_TextBox.Text;
            string email = Email_TextBox.Text;
            string gender = Gender_TextBox.Text;
            string password = Password_TextBox.Text;
            string confirmPassword = ConfirmPassword_TextBox.Text;
            int buyerid = int.Parse(Request.QueryString["buyerid"]);
            // pindahin ke controller dulu data di atas, abis itu update status infonya
            Info_Label.Text = userController.updateProfile(buyerid, username, email, gender, password, confirmPassword);
            Response.Redirect($"Profile.aspx?buyerid={buyerid}");
        }
    }
}