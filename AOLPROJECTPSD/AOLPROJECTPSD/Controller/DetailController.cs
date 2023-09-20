using AOLPROJECTPSD.Handler;
using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Controller
{
    public class DetailController
    {
        public static void addCart(int ramenid, int quantity, int buyerId, int sellerId, string date)
        {
            int idheader = HeaderHandler.findHeaderId(buyerId, sellerId, date);
            DetailHandler.createDetail(idheader, ramenid, quantity);
        }
        public static Detail getDetail(int id)
        {
            return DetailHandler.getDetail(id);
        }
        //public static string 
    }
}