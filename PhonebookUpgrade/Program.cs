using System;
using System.Collections.Generic;

namespace PhoneBookUpgrade
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            var phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phonebook[input[1]] = input[2];

                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var number in phonebook)
                    {
                        Console.WriteLine($"{number.Key} -> {number.Value}");
                    }
                }

                input = Console.ReadLine().Split(' ');
            }
        }
    }
}