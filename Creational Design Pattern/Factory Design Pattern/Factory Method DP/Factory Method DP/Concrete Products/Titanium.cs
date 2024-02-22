using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_DP.Concrete_Products
{
    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCardLimit()
        {
            return 40000;
        }

        public int GetAnnualCharge()
        {
            return 5000;
        }
    }
}
