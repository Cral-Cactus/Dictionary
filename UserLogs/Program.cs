using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    internal class Program
    {
        static void Main()
        {
            string input;
            var userLogs = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] parts = input.Split(' ');
                string ip = parts.First(p => p.StartsWith("IP=")).Substring(3);
                string message = parts.First(p => p.StartsWith("message='")).Substring(9);
                string user = parts.First(p => p.StartsWith("user=")).Substring(5);

                if (!userLogs.ContainsKey(user))
                {
                    userLogs[user] = new Dictionary<string, int>();
                }

                if (!userLogs[user].ContainsKey(ip))
                {
                    userLogs[user][ip] = 0;
                }

                userLogs[user][ip]++;
            }

            foreach (var userEntry in userLogs.OrderBy(u => u.Key))
            {
                string user = userEntry.Key;
                Dictionary<string, int> ipStats = userEntry.Value;
                Console.WriteLine($"{user}");

                var formattedIpStats = ipStats.Select(kvp => $"{kvp.Key} => {kvp.Value}");
                Console.WriteLine($"{string.Join(", ", formattedIpStats)}.");
            }
        }
    }
}