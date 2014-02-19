using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.DM;
using ServiceStack;

namespace POS.API.Responses
{
    
    public class DealsResponse
    {
        public List<Deal> Deals { get; set; }
    }
}
