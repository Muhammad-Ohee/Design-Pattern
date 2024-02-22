using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_DP.Concrete_Products
{
    internal class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCardLimit()
        {
            return 20000;
        }

        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
