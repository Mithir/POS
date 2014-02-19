using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.DataAccess;
using POS.DM;

namespace POS.BL
{
    public class Deals
    {
        public List<Deal> GetAllDeals()
        {
            DealRepository dealRepo = new StaticListDealRepository();
            return dealRepo.GetDeals();
        }
    }
}
