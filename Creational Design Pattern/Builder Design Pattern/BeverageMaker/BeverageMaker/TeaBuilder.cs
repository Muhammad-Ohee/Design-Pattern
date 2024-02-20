using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageMaker
{
    class TeaBuilder : BeverageBuilder
    {
        public override void SetWater()
        {
            Console.WriteLine("Step 1: Boiling Water.");
            GetBeverage().Water = 60;
        }

        public override void SetMilk()
        {
            Console.WriteLine("Step 2: Adding Milk.");
            GetBeverage().Milk = 250;
        }

        public override void SetSugar()
        {
            Console.WriteLine("Step 3: Adding Sugar.");
            beverageObject.Sugar = 13;
        }

        public override void SetPowderQuantity()
        {
            Console.WriteLine("Step 4: Adding 2 tea spoons of tea powder.");
            GetBeverage().PowerQuantity = 2;
        }

        public override void SetBeverageType()
        {
            //Console.WriteLine("Tea.");
            GetBeverage().BeverageName = "Tea";
        }
    }
}
