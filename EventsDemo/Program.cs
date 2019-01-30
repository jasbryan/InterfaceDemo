using System;

namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyStock = new Stock
            {
                Symbol = "MSFT",
                Price = 102.94M
            };

            MyStock.PriceChanged += NotifyMe;
            MyStock.PriceChanged += NotifyMeAgain;

            MyStock.Price = 120.45M;
            MyStock.PriceChanged -= NotifyMeAgain;

            MyStock.Price = 110.10M;
        }

        static void NotifyMe(PriceChangedEventArgs args)
        {
            Console.WriteLine($"oldprice: {args.OldPrice}, newPrice: {args.NewPrice}");
        }

        static void NotifyMeAgain(PriceChangedEventArgs args)
        {
            Console.WriteLine($"Again--oldprice: {args.OldPrice}, newPrice: {args.NewPrice}");
        }
    }
}
