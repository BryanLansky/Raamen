using AOLPROJECTPSD.Model;
using AOLPROJECTPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Handler
{
    public class HeaderHandler
    {
        public static List<Header> getAllHeaderDoneByCustomerId(int buyerid)
        {
            return HeaderRepository.getAllHeaderDoneByCustomerId(buyerid);
        }
        public static void deleteCart(int buyerid)
        {
            HeaderRepository.deleteCart(buyerid);
        }
        public static int findHeaderId(int buyerId, int sellerId, string date)
        {
            return HeaderRepository.findHeaderId(buyerId, sellerId, date);
        }
        public static void createOrder(int buyerId, int sellerId, string date, int status)
        {
            HeaderRepository.createOrder(buyerId, sellerId, date, status);
            return;
        }
        public static Header getHeader(int headerId)
        {
            return HeaderRepository.getHeader(headerId);
        }
        public static List<Header> getAllHeader()
        {
            return HeaderRepository.getAllHeader();
        }
        public static List<Header> getAllHeaderByStatus(int status)
        {
            return HeaderRepository.getAllHeaderByStatus(status);
        }
    }
}