//Console.WriteLine("Hello, OS");

using LogisticsApplication.ConcreteCreator;

namespace LogisticsApplication
{
    public class LogisticsCost
    {
        public double TravelCost(LogisticsAbstract logisticsAbstract, int distance)
        {
            ILogisticsApplication iLogisticsApplication = logisticsAbstract.CreateTransportObject();
            var travelCost = iLogisticsApplication.GetDeliveryCost(distance);
            return travelCost;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LogisticsCost logisticsCost = new LogisticsCost();
            var travelCost = logisticsCost.TravelCost(new TruckFactory(), 100);
            Console.WriteLine($"Truck delivery cost: ${travelCost} for 100 miles.");

            travelCost = logisticsCost.TravelCost(new ShipFactory(), 100);
            Console.WriteLine($"Ship delivery cost: ${travelCost} for 100 miles.");

            travelCost = logisticsCost.TravelCost(new PlaneFactory(), 100);
            Console.WriteLine($"Plane delivery cost: ${travelCost} for 100 miles.");
        }
    }
}

