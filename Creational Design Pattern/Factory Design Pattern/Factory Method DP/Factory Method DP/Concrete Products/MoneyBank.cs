using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_DP.Concrete_Products
{
    public class MoneyBank : ICreditCard
    {
        public string GetCardType()
        {
            return "Money Bank";
        }

        public int GetCardLimit()
        {
            return 15000;
        }

        public int GetAnnualCharge()
        {
            return 1000;
        }
    }
}
