using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticsApplication.ConcreteProducts;

namespace LogisticsApplication.ConcreteCreator
{
    public class PlaneFactory : LogisticsAbstract
    {
        public override ILogisticsApplication CreateTransportObject()
        {
            return new Plane();
        }
    }
}
