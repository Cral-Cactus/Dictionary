using System;
using System.Collections.Generic;

namespace OddEncounters
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] words = input.ToLower().Split(' ');

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }

            List<string> oddOccurrences = new List<string>();

            foreach (var pair in wordCounts)
            {
                if (pair.Value % 2 == 1)
                {
                    oddOccurrences.Add(pair.Key);
                }
            }

            //oddOccurrences.Sort();
            Console.WriteLine(string.Join(", ", oddOccurrences));
        }
    }
}