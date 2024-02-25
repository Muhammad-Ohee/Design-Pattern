using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsApplication.ConcreteProducts
{
    public class Ship : ILogisticsApplication
    {
        public double GetDeliveryCost(int distance)
        {
            // Cost per mile for a ship might be $25.00
            return 25.00 * distance;
        }
    }
}
