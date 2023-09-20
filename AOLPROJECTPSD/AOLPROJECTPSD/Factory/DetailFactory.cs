using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Factory
{
    public class DetailFactory
    {
        public static Detail createDetail(int headerId, int ramenId, int quantity)
        {
            Detail detail = new Detail();
            detail.Headerid = headerId;
            detail.Ramenid = ramenId;
            detail.Quantity = quantity;
            return detail;
        }
    }
}