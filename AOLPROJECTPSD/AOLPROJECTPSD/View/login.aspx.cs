using AOLPROJECTPSD.Controller;
using AOLPROJECTPSD.Model;
using AOLPROJECTPSD.View.AdminFolder;
using AOLPROJECTPSD.View.BuyerFolder;
using AOLPROJECTPSD.View.SellerFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // kosongin textbox = "";
            if (!IsPostBack)
            {
                UsernameTxt.Text = "";
                PasswordTxt.Text = "";
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            // ambil data textbox 
            String Username = UsernameTxt.Text;
            String Password = PasswordTxt.Text;
            bool isChecked = remembermeChkbx.Checked;
            String Validasi = userController.Login(Username, Password, isChecked);
            if (Validasi.Equals("User Logged on"))
            {
                int id = userController.getUserByUsername(Username).Id; // ambil idnya buat di query string parameter
                int roleid = userController.getUserByUsername(Username).RoleId; // buat nentuin nanti ke admin or etc

                //Sesi dan cookie
                if (id.ToString() != null && roleid.ToString() != null)
                {
                    Session["user"] = userController.GetUserByIDandRoleId(id, roleid);
                    if (isChecked)
                    {
                        HttpCookie userCookie = new HttpCookie("userCookie");
                        userCookie.Value = id.ToString();
                        userCookie.Expires.AddDays(30);
                        Response.Cookies.Add(userCookie);
                    }
                }

                if (roleid == 1)
                {
                    Sesi.id = id;
                    Response.Redirect($"AdminFolder\\home_admin.aspx?id={id}");
                }
                else if (roleid == 2)
                {
                    SellerSesi.SellerId = id;
                    Response.Redirect($"SellerFolder\\home_seller.aspx?sellerid={id}");
                }
                else
                {
                    BuyerSesi.buyerId = id;
                    Response.Redirect($"BuyerFolder\\home_buyer.aspx?buyerid={id}");
                }
            }
            errorLbl.Text = Validasi;
        }
    }
}