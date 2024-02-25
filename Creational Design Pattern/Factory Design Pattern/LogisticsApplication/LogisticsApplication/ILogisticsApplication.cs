using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsApplication
{
    // Product (Interface)
    public interface ILogisticsApplication
    {
        double GetDeliveryCost(int distance);
    }
}
