using AOLPROJECTPSD.Factory;
using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Repository
{
    public class HeaderRepository
    {
        static DBEntities1 db = new DBEntities1();
        //1. CREATE
        public static void  createOrder(int buyerId, int sellerId, string date, int status)
        {
            Header transaction = HeaderFactory.createHeader(buyerId, sellerId, date, status);
            db.Headers.Add(transaction);
            db.SaveChanges();
            return;
        }
        //2. READ
        public static List<Header> getAllHeaderDoneByCustomerId(int buyerid)
        {
            List<Header> allHeaderDone = getAllHeaderByStatus(1);
            List<Header> allHeaderBuyerId = new List<Header>();

            foreach(Header header in allHeaderBuyerId)
            {
                if (header.CustomerId == buyerid)
                    allHeaderBuyerId.Add(header);
            }
            return allHeaderBuyerId;
        }
        public static int findHeaderId(int buyerId, int sellerId, string date)
        {
            List<Header> allHeader = getAllHeaderByStatus(2);
            foreach(Header header in allHeader)
            {
                if ((header.CustomerId == buyerId) && (header.StaffId == sellerId) && (header.DATE.ToString().Equals(date)));
                {
                    return header.Id;
                }
            }
            return 0;
        }
        public static Header getHeader(int headerId) // ambil header/transaction berdasar id
        {
            Header header = db.Headers.Find(headerId);
            return header;
        }
        public static List<Header> getAllHeader()
        {
            return db.Headers.ToList();
        }
        public static List<Header> getAllHeaderByStatus(int status)
        {
            List<Header> allHeader = db.Headers.ToList();
            List<Header> HeaderList = new List<Header>();
            foreach (Header header in allHeader)
            {
                if (header.Status == status)
                {
                    HeaderList.Add(header);
                }
            }
            return HeaderList;
        }
        // 3.REMOVE
        public static void deleteHeader(Header header)
        {
            db.Headers.Remove(header);
            db.SaveChanges();
        }
        public static void deleteCart(int buyerid)
        {
            List<Header> allHeader = getAllHeaderByStatus(2);
            foreach(Header header in allHeader)
            {
                if (header.CustomerId == buyerid)
                    deleteHeader(header);
            }
        }
    }
}