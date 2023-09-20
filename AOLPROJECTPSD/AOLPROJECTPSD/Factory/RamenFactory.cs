using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Factory
{
    public class RamenFactory
    {
        public static Raman createRamen(int meatId, string name, string broth, string price)
        {
            Raman ramen = new Raman();
            ramen.Meatid = meatId;
            ramen.Name = name;
            ramen.Broth = broth;
            ramen.Price = price;
            return ramen;
        }
    }
}