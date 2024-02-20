using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageMaker
{
    class CoffeeBuilder : BeverageBuilder
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
            GetBeverage().Sugar = 13;
        }

        public override void SetPowderQuantity()
        {
            Console.WriteLine("Step 4: Adding 1 teaspoon of coffee powder.");
            GetBeverage().PowerQuantity = 1;
        }

        public override void SetBeverageType()
        {
            //Console.WriteLine("Coffee.");
            GetBeverage().BeverageName = "Coffee";
        }
    }
}
