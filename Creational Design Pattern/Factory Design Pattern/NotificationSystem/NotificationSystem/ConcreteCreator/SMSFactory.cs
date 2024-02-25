using NotificationSystem.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.ConcreteCreator
{
    // Concrete Creators
    public class SMSFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new SMSNotifier();
        }
    }
}
