using System;
using System.Collections.Generic;

namespace CountRealNums
{
    internal class Program
    {
        static void Main()
        {
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            foreach (string number in numbers)
            {
                double num = double.Parse(number);

                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            foreach (var pair in counts)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}