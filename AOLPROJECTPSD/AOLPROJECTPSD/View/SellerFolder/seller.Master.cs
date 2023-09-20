using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.SellerFolder
{
    public partial class seller : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            int sellerId = SellerSesi.SellerId;
            Response.Redirect($"home_seller.aspx?sellerid={sellerId}");
        }

        protected void ManageBtn_Click(object sender, EventArgs e)
        {
            int sellerId = SellerSesi.SellerId;
            Response.Redirect($"ManageRamen.aspx?sellerid={sellerId}");
        }

        protected void QueueBtn_Click(object sender, EventArgs e)
        {
            int sellerId = SellerSesi.SellerId;
            Response.Redirect($"OrderQueue.aspx?sellerid={sellerId}");
        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            int sellerId = SellerSesi.SellerId;
            Response.Redirect($"Profile.aspx?sellerid={sellerId}");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            SellerSesi.SellerId = 0;
            Response.Redirect("../login.aspx");
        }
    }
}