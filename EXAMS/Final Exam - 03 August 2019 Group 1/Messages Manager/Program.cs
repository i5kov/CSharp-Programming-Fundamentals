using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int capacity = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();
        Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

        while (command != "Statistics")
        {
            string[] split = command.Split("=");
            if (command.Contains("Add"))
            {
                if (!dict.ContainsKey(split[1]))
                {
                    dict.Add(split[1], new List<int>() { int.Parse(split[2]), int.Parse(split[3]) });
                }
            }
            if (command.Contains("Message"))
            {
                string sender = split[1];
                string receiver = split[2];
                if (dict.ContainsKey(sender) && dict.ContainsKey(receiver))
                {
                    dict[sender][0]++;
                    dict[receiver][1]++;
                    if (dict[sender][1] + dict[sender][0] >= capacity)
                    {
                        dict.Remove(sender);
                        Console.WriteLine($"{sender} reached the capacity!");
                    }
                    if (dict[receiver][1] + dict[receiver][0] >= capacity)
                    {
                        dict.Remove(receiver);
                        Console.WriteLine($"{receiver} reached the capacity!");
                    }
                }
            }
            if (command.Contains("Empty"))
            {
                if (split[1] == "All")
                {
                    foreach (var item in dict)
                    {
                        dict.Remove(item.Key);
                    }
                }
                else
                {
                    if (dict.ContainsKey(split[1]))
                    {
                        dict.Remove(split[1]);
                    }
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"Users count: {dict.Count}");

        foreach (var item in dict.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} - {item.Value[0] + item.Value[1]}");
        }
    }
}