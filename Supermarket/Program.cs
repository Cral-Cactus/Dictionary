using System;
using System.Collections.Generic;

namespace Supermarket
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            Dictionary<string, double> stocksPrices = new Dictionary<string, double>();
            Dictionary<string, int> stocksQty = new Dictionary<string, int>();
            double total = 0.0;

            while (input[0] != "stocked")
            {
                if (!stocksQty.ContainsKey(input[0]))
                {
                    stocksQty[input[0]] = 0;
                }

                stocksPrices[input[0]] = double.Parse(input[1]);
                stocksQty[input[0]] += int.Parse(input[2]);

                input = Console.ReadLine().Split(' ');
            }

            foreach (var product in stocksPrices)
            {
                total += product.Value * stocksQty[product.Key];
                Console.WriteLine($"{product.Key}: ${product.Value:F2} * {stocksQty[product.Key]} = ${product.Value * stocksQty[product.Key]:F2}");
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${total:F2}");
        }
    }
}