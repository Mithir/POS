using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS.DM
{
    public class Deal
    {
        public double Amount { get; set; }

        public List<Product> DealProducts { get; set; }

    }
}
