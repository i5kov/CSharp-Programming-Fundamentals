using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();
        Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

        while (command != "End")
        {
            string[] split = command.Split();
            if (command.Contains("Enroll"))
            {
                if (!heroes.ContainsKey(split[1]))
                {
                    heroes.Add(split[1], new List<string>());
                }
                else
                {
                    Console.WriteLine($"{split[1]} is already enrolled.");
                }
            }
            if (command.Contains("Learn"))
            {
                if (!heroes.ContainsKey(split[1]))
                {
                    Console.WriteLine($"{split[1]} doesn't exist.");
                }
                else
                {
                    if (heroes[split[1]].Contains(split[2]))
                    {
                        Console.WriteLine($"{split[1]} has already learnt {split[2]}.");
                    }
                    else
                    {
                        heroes[split[1]].Add(split[2]);
                    }
                }
            }
            if (command.Contains("Unlearn"))
            {
                if (!heroes.ContainsKey(split[1]))
                {
                    Console.WriteLine($"{split[1]} doesn't exist.");
                }
                else
                {
                    if (!heroes[split[1]].Contains(split[2]))
                    {
                        Console.WriteLine($"{split[1]} doesn't know {split[2]}.");
                    }
                    else
                    {
                        heroes[split[1]].Remove(split[2]);
                    }
                }
            }

            command = Console.ReadLine();
        }
        Console.WriteLine("Heroes:");
        foreach (var item in heroes.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            
            Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)}");
        }
    }
}