using AOLPROJECTPSD.Model;
using AOLPROJECTPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Handler
{
    public class RamenHandler
    {
        public static Meat getMeat(int id)
        {
            return RamenRepository.getMeat(id);
        }
        public static void createRamen(int meatId, string name, string broth, string price)
        {
            RamenRepository.createRamen(meatId, name, broth, price);
            return;
        }
        public static Raman getRamen(int ramenId)
        {
            return RamenRepository.getRamen(ramenId);
        }
        public static List<Raman> getAllRamen()
        {
            return RamenRepository.getAllRamen();
        }
        public static Boolean updateRamen(int ramenId, int meatId, string name, string broth, string price)
        {
            return RamenRepository.updateRamen(ramenId, meatId, name, broth, price);
        }
        public static Boolean deleteRamen(int ramenId)
        {
            return RamenRepository.deleteRamen(ramenId);
        }

        public static List<Raman> getRamens()
        {
            return RamenRepository.getRamens();
        }
    }
}