using AOLPROJECTPSD.Controller;
using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.AdminFolder
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
                    Sesi.id = ID;
                    Response.Redirect($"Profile.aspx?id={ID}");
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

            // ambil data customer dulu abis itu tampilin
            int userId = Sesi.id;
            User user = userController.getUser(userId);
            Username_Label.Text = user.Username;
            Email_Label.Text = user.Email;
            Gender_Label.Text = user.Gender;
            Password_Label.Text = user.Password;

        }

        protected void Update_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect($"UpdateProfile.aspx?id={Sesi.id}");
        }
    }
}