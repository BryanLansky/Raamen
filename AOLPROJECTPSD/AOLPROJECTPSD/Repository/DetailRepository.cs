using AOLPROJECTPSD.Factory;
using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Repository
{
    public class DetailRepository
    {
        static DBEntities1 db = new DBEntities1();
        //CR HEADER/TRANSACTION TIDAK BOLEH DIUPDATE ATAU DIHAPUS
        //1. CREATE
        public static void createDetail(int headerId, int ramenId, int quantity)
        {
            Detail detail = DetailFactory.createDetail(headerId, ramenId, quantity);
            db.Details.Add(detail);
            db.SaveChanges();
            return;
        }
        //2. READ
        public static Detail getDetail(int detailId)
        {
            Detail detail = db.Details.Find(detailId);
            return detail;
        }
    }
}