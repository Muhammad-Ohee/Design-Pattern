using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationSystem.ConcreteProducts;

namespace NotificationSystem.ConcreteCreator
{
    // Concrete Creators
    public class EmailFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new EmailNotifier();
        }
    }
}
