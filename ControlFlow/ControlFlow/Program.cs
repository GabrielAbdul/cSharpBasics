using System;

namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // switch case
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    {
                        Console.WriteLine("There is a promotion");
                        break;
                    }
                default:
                    Console.WriteLine("what season is that?");
                    break;
            }

            // if else and ternary
            int hour = 10;
            bool isGoldCustomer = true;

            if (hour > 0 && hour < 12)
                Console.WriteLine("It's morning.");
            else if (hour >= 12 && hour <= 18)
                Console.WriteLine("It's afternoon");
            else
                Console.WriteLine("It's evening.");

            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            float priceTwo = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(String.Format("price: {0} priceTwo: {1}", price, priceTwo));
        }
    }
}
