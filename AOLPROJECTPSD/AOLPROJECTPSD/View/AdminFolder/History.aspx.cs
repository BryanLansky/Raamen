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
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // kalo cookie ada, sesi gada
            if (Session["user"] == null && Response.Cookies["userCookie"] != null)
            {
                //masukin sesi dari kuki
                if (int.TryParse(Request.Cookies["userCookie"].Value, out int ID))
                {
                    Session["user"] = userController.getUser(ID);
                    Sesi.id = ID;
                    Response.Redirect($"History.aspx?id={ID}");
                }
                // jika tidak
                else
                {
                    Response.Redirect("../login.aspx");
                }
            }
            //kalo sesi gada dan kuki gada
            else if (Session["user"] == null && Response.Cookies["userCookie"] == null)
            {
                Response.Redirect("../login.aspx");
            }


            if (!IsPostBack)
            {
                //Transaction_GridView
                Transaction_GridView.DataSource = HeaderController.getAllHeaderDone();
                Transaction_GridView.DataBind();
            }
        }

        protected void CheckTransaction_Button_Click(object sender, EventArgs e)
        {
            string transaction_id = TransactionId_TextBox.Text;
            // kalo gak ketemu Info_Label = "Wrong ID"
            // kalo ketemu langsung Response.Redirect("OrderDetail.aspx"); terus kasih transactionID
            string validasi = HeaderController.checkTransactionId(transaction_id);
            if (!validasi.Equals("found"))
                Info_Label.Text = validasi;
                return;
            Header headerId = HeaderController.getHeader(int.Parse(transaction_id));
            Response.Redirect($"OrderDetail.aspx?headerid={headerId}");

        }
    }
}