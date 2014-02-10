using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.DM;

namespace POS.DataAccess
{
    public abstract class ProductRepository
    {
        public abstract List<Product> GetProductsForCompany(long companyId = 0);

    }
}
