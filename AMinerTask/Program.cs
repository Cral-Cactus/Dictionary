using System;
using System.Collections.Generic;

namespace AMinerTask
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (input != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(input))
                {
                    //resources[input] = 0; // This is the same as the next line
                    resources.Add(input, 0);
                }

                resources[input] += quantity;


                input = Console.ReadLine();
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}