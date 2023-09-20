using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.AdminFolder
{
    public partial class admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ManageBtn_Click(object sender, EventArgs e)
        {
            int id = Sesi.id;
            Response.Redirect($"ManageRamen.aspx?id={id}");
        }

        protected void QueueBtn_Click(object sender, EventArgs e)
        {
            int id = Sesi.id;
            Response.Redirect($"OrderQueue.aspx?id={id}");
        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            int id = Sesi.id;
            Response.Redirect($"Profile.aspx?id={id}");
        }

        protected void HistoryBtn_Click(object sender, EventArgs e)
        {
            int id = Sesi.id;
            Response.Redirect($"History.aspx?id={id}");
        }

        protected void ReportBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReportPage.aspx");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Sesi.id = 0; // reset 
            Session["user"] = null;
            Response.Redirect("../login.aspx");
        }
    }
}