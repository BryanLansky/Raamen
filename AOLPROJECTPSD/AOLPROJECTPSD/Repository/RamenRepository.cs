using AOLPROJECTPSD.Factory;
using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Repository
{
    public class RamenRepository
    {
        static DBEntities1 db = new DBEntities1();
        //CRUD USER
        //1. Create
        public static void createRamen(int meatId, string name, string broth, string price)
        {
            Raman ramen = RamenFactory.createRamen(meatId, name, broth, price);
            db.Ramen.Add(ramen);
            db.SaveChanges();
            return;
        }
        //2. Read
        public static Raman getRamen(int ramenId) // cari satu user
        {
            Raman ramen = db.Ramen.Find(ramenId);
            return ramen; // ketemu return ramen kalo ga return null bawaan fungsi .find()
        }
        public static List<Raman> getAllRamen() // ambil semua data user sesuai role
        {
            return db.Ramen.ToList();
        }
        //3. Update
        public static Boolean updateRamen(int ramenId, int meatId, string name, string broth, string price)
        {
            Raman updatedRamen = getRamen(ramenId);
            if (updatedRamen != null)
            {
                updatedRamen.Meatid = meatId;
                updatedRamen.Name = name;
                updatedRamen.Broth = broth;
                updatedRamen.Price = price;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        //4. Delete
        public static Boolean deleteRamen(int ramenId)
        {
            Raman deletedRamen = getRamen(ramenId);
            if (deletedRamen != null)
            {
                db.Ramen.Remove(deletedRamen);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public static Meat getMeat(int id)
        {
            return db.Meats.Find(id);
        }

        public static List<Raman> getRamens()
        {
            DBEntities1 db = new DBEntities1();
            return db.Ramen.ToList();
        }
    }
}