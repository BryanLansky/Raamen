using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Factory
{
    public class HeaderFactory
    {
        public static Header createHeader(int buyerId, int sellerId, string date, int status)
        {
            Header header = new Header();
            header.CustomerId = buyerId;
            header.StaffId = sellerId;
            header.DATE = DateTime.Parse(date);
            header.Status = status;
            return header;
        }
    }
}