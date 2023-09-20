using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.BuyerFolder
{
    public partial class buyer : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OrderBtn_Click(object sender, EventArgs e)
        {
            int buyerid = BuyerSesi.buyerId;
            Response.Redirect($"OrderRamen.aspx?buyerid={buyerid}");
        }

        protected void HistoryBtn_Click(object sender, EventArgs e)
        {
            int buyerid = BuyerSesi.buyerId;
            Response.Redirect($"History.aspx?buyerid={buyerid}");
        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            int buyerid = BuyerSesi.buyerId;
            Response.Redirect($"Profile.aspx?buyerid={buyerid}");
        }
        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            BuyerSesi.buyerId = 0;
            Session["user"] = null;
            Response.Redirect("../login.aspx");
        }
    }
}