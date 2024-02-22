using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFDP
{
    public class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string CardType)
        {
            CreditCard creditCard = null;

            if (CardType == "Platinum")
            {
                creditCard = new Platinum();
            }
            else if (CardType == "Titanium")
            {
                creditCard = new Titanium();
            }
            else if (CardType == "Money Bank")
            {
                creditCard = new MoneyBank();
            }

            return creditCard;
        }
    }
}
