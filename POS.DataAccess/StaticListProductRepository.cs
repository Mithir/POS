using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.DM;

namespace POS.DataAccess
{
    class StaticListProductRepository : ProductRepository
    {
        private static List<Product> products = new List<Product>
        {
            new Product{ Description = "משחת שיניים", Price = 12.90d},
            new Product{ Description = "דיאודורנט", Price = 21.90d},
            new Product{ Description = "בושם", Price = 144.90d},
            new Product{ Description = "קרם ידיים", Price = 19.90d},
            new Product{ Description = "תחליב רחצב", Price = 10.90d},
            new Product{ Description = "שמפו", Price = 11.90d},
            new Product{ Description = "סבון", Price = 6.90d}
        };
        public override List<Product> GetProductsForCompany(long companyId = 0)
        {
            return products;
        }
    }
}
