using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFDP
{
    public class MoneyBank : CreditCard
    {
        public string GetCardType()
        {
            return "Money Bank";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }

        public int GetAnnualCharge()
        {
            return 1000;
        }
    }
}
