using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.DM;

namespace POS.DataAccess
{
    public class StaticListDealRepository : DealRepository
    {
        private static List<Deal> deals = new List<Deal>
        {
            new Deal
            {
                Amount = 109.90, 
                DealProducts = new List<Product>
                {
                    new Product{ Description = "משחת שיניים", Price = 12.90d},
                    new Product{ Description = "דיאודורנט", Price = 21.90d}
                }
            },
            new Deal
            {
                Amount = 79.90, 
                DealProducts = new List<Product>
                {
                    new Product{ Description = "משחת שיניים", Price = 12.90d},
                    new Product{ Description = "דיאודורנט", Price = 21.90d}
                }
            }
        
        };
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
