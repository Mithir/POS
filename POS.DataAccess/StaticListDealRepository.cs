using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.DM;

namespace POS.DataAccess
{
    class StaticListDealRepository : DealRepository
    {
        private static List<Deal> deals = new List<Deal>();
        public override List<Deal> GetDeals(long companyId = 0)
        {
            return deals;
        }

        public override bool AddDeal(Deal deal)
        {
            deals.Add(deal);
            return true;
        }
    }
}
