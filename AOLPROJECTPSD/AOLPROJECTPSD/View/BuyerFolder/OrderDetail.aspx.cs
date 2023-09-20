using AOLPROJECTPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View.BuyerFolder
{
    public partial class OrderDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int headerId = int.Parse(Request.QueryString["id"]);
            int quantity = DetailController.getDetail(headerId).Quantity;
            int ramenPrice = int.Parse(RamenController.getRamen(DetailController.getDetail(headerId).Ramenid).Price);

            Transaction_Id_Label.Text = headerId.ToString();
            Customer_Name_Label.Text = userController.getUser(HeaderController.getHeader(headerId).CustomerId).Username;
            RamenName_Label.Text = RamenController.getRamen(DetailController.getDetail(headerId).Ramenid).Name;
            Price_Total_Label.Text = (quantity * ramenPrice).ToString();
        }
    }
}