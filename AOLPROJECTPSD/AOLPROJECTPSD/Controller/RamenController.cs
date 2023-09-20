using AOLPROJECTPSD.Handler;
using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Controller
{
    public class RamenController
    {
        public static Meat getMeat(int id)
        {
            return RamenHandler.getMeat(id);
        }
        public static void deleteRamen(int id)
        {
            RamenHandler.deleteRamen(id);
        }
        //public static String updateRamen(int ramenId, int meatId, string name, string broth, string price)
        //{
        //    VALIDASIIN JEREMIA
        //    RamenHandler.updateRamen(ramenId, meatId, name, broth, price);
        //    return "berhasil";
        //}
        public static String updateRamen(int ramenId, int meatId, string name, string broth, string price)
        {
            if (!(name.Contains("Ramen")))
            {
                return "Must contains ‘Ramen’.";
            }
            else if (meatId.Equals(""))
            {
                return "Must be selected.";
            }
            else if (broth.Equals(""))
            {
                return "Cannot be Empty.";
            }
            else if (!(int.Parse(price) >= 3000))
            {
                return "Price must be at least 3000.";
            }
            if (RamenHandler.updateRamen(ramenId, meatId, name, broth, price) == false)
            {
                return "User not found";
            }
            else
            {
                return "berhasil";
            }
        }
        public static String createRamen(string meatId, string name, string broth, string price)
        {

            if (!(name.Contains("Ramen")))
            {
                return "Must contains ‘Ramen’.";
            }
            else if(meatId.Equals(""))
            {
                return "Must be selected.";
            }
            else if(broth.Equals(""))
            {
                return "Cannot be Empty.";
            }
            else if (!(int.Parse(price) >= 3000))
            {
                return "Price must be at least 3000.";
            }

            RamenHandler.createRamen(int.Parse(meatId),name,broth,price);
            return "Success";
        }
        public static List<Raman> getAllRamen()
        {
            return RamenHandler.getAllRamen();
        }
        public static Raman getRamen(int id)
        {
            return RamenHandler.getRamen(id);
        }
    }
}