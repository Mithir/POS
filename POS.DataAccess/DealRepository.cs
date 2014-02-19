using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.DM;

namespace POS.DataAccess
{
    public abstract class DealRepository
    {
        abstract public List<Deal> GetDeals(long companyId = 0);

        abstract public bool AddDeal(Deal deal);

    }
}
