using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageMaker
{
    public class Beverage
    {
        // This is the Product Class

        public int Water { get; set; }
        public int Milk { get; set; }
        public int Sugar { get; set; }
        public int PowerQuantity { get; set; }
        public string BeverageName { get; set; }

        public string ShowBeverage()
        {
            string str = $"\nHot {BeverageName} Recipe" +
                          $"\nRecipie: " +
                          $"{Water} ml of water," +
                          $" {Milk} ml of milk," +
                          $" {Sugar} teaspoon of sugar and" +
                          $" {PowerQuantity} teaspoons of {BeverageName} powder.";
            return str;
        }
    }
}
