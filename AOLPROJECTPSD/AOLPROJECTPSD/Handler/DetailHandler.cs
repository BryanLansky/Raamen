using AOLPROJECTPSD.Model;
using AOLPROJECTPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Handler
{
    public class DetailHandler
    {
        public static void createDetail(int headerId, int ramenId, int quantity)
        {
            DetailRepository.createDetail(headerId, ramenId, quantity);
            return;
        }
        public static Detail getDetail(int detailId)
        {
            return DetailRepository.getDetail(detailId);
        }
    }
}