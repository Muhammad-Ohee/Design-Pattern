using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageMaker
{
    public abstract class BeverageBuilder
    {
        protected Beverage beverageObject;

        public abstract void SetWater();
        public abstract void SetMilk();
        public abstract void SetSugar();
        public abstract void SetPowderQuantity();
        public abstract void SetBeverageType();

        public void CreateBeverageObject()
        {
            beverageObject = new Beverage();
        }

        public Beverage GetBeverage()
        {
            return beverageObject;
        }
    }
}
