using AOLPROJECTPSD.Model;
using AOLPROJECTPSD.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AOLPROJECTPSD.Dataset;
using AOLPROJECTPSD.Handler;

namespace AOLPROJECTPSD.View.AdminFolder
{
    public partial class reportPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport report = new CrystalReport();
            CrystalReportViewer1.ReportSource = report;
            DataSet data = getData(RamenHandler.getRamens());
            report.SetDataSource(data);
        }

        private DataSet getData(List<Raman> ramen)
        {
            DataSet data = new DataSet();
            var headertable = data.Ramen;
            var detailtable = data.Details;

            foreach (Raman t in ramen)
            {
                var hrow = headertable.NewRow();
                hrow["id"] = t.Id;
                hrow["Meatid"] = t.Meatid;
                //hrow["Borth"] = t.Broth;
                hrow["Price"] = t.Price;
                headertable.Rows.Add(hrow);

                foreach(Detail d in t.Details)
                {
                    var drow = detailtable.NewRow();
                    drow["id"] = d.Id;
                    drow["Headerid"] = d.Headerid;
                    drow["Ramenid"] = d.Ramenid;
                    drow["Quantity"] = d.Quantity;
                    detailtable.Rows.Add(drow);
                }

            }
            return data;
        }
    }
}