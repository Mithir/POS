using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.API.Requests;
using POS.API.Responses;
using POS.BL;
using ServiceStack;

namespace POS.API
{
    public class DealsService : Service
    {
        public DealsResponse Get(DealsRequest dealReq)
        {
            Deals dealBL = new Deals();
            return new DealsResponse
            {
                Deals = dealBL.GetAllDeals()
            };
        }
    }
}
