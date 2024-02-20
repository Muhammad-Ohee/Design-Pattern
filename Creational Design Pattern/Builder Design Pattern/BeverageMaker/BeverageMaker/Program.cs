//Console.WriteLine("Hello, OS");

namespace BeverageMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client Side

            Beverage beverage;
            BeverageDirector beverageDirector = new BeverageDirector();

            //Tea Making
            Console.WriteLine("Hot Tea Making");
            TeaBuilder teaBuilder = new TeaBuilder();
            beverage = beverageDirector.MakeBeverage(teaBuilder);
            Console.WriteLine(beverage.ShowBeverage());
            Console.WriteLine("Recipe Done!");

            Console.WriteLine("- - - - - - - - - - - - - - -");

            // Coffee Making
            Console.WriteLine("Hot Coffee Making");
            CoffeeBuilder coffeeBuilder = new CoffeeBuilder();
            beverage = beverageDirector.MakeBeverage(coffeeBuilder);
            Console.WriteLine(beverage.ShowBeverage());
            Console.WriteLine("Recipe Done!");
        }
    }
}