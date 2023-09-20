using AOLPROJECTPSD.Handler;
using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Controller
{
    public class HeaderController
    {
        public static List<Header> getAllHeaderDoneByCustomerId(int buyerid)
        {
            return HeaderHandler.getAllHeaderDoneByCustomerId(buyerid);
        }
        public static void buyCart(int buyerid) // Make status header to unhandle status
        {
            List<Header> allHeader = HeaderHandler.getAllHeaderByStatus(2);
            List<Header> headerBuyerCart = new List<Header>();

            foreach(Header header in allHeader)
            {
                if(header.CustomerId == buyerid)
                    headerBuyerCart.Add(header);
            }

            foreach(Header header in headerBuyerCart)
                header.Status = 0;
        }
        public static void deleteCart(int buyerid)
        {
            HeaderHandler.deleteCart(buyerid);
        }
        public static void addCart(int buyerId, string date, int status)
        {
            HeaderHandler.createOrder(buyerId, 2, date, status);
        }
        public static void updateStatusHeaderDone(int id)//done
        {
            getHeader(id).Status = 1;
        }
        public static List<Header> getAllHeaderDone()
        {
            return HeaderHandler.getAllHeaderByStatus(1); //1=Done 0 = unhandled
        }
        public static List<Header> getAllHeaderUnhandled()
        {
            return HeaderHandler.getAllHeaderByStatus(0); //1=Done 0 = unhandledS
        }
        public static Header getHeader(int id)
        {
            return HeaderHandler.getHeader(id);
        }
        public static string checkTransactionId(string id)
        {
            if (id.Equals(""))
                return "Can't empty";
            if (getHeader(int.Parse(id)) == null)
                return "Not Found";
            return "found";
        }
    }
}