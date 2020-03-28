using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();
        Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
        int count = 0;
        while (command != "Stop")
        {
            string[] split = command.Split("-");
            if (command.Contains("Like"))
            {
                if (!guests.ContainsKey(split[1]))
                {
                    guests.Add(split[1], new List<string>());
                }
                if (!guests[split[1]].Contains(split[2]))
                {
                    guests[split[1]].Add(split[2]);
                }
            }
            if (command.Contains("Unlike"))
            {
                if (!guests.ContainsKey(split[1]))
                {
                    Console.WriteLine($"{split[1]} is not at the party.");
                }
                
                if (guests.ContainsKey(split[1]))
                {
                    if (!guests[split[1]].Contains(split[2]))
                    {
                        Console.WriteLine($"{split[1]} doesn't have the {split[2]} in his/her collection.");
                    }
                    else
                    {
                        guests[split[1]].Remove(split[2]);
                        Console.WriteLine($"{split[1]} doesn't like the {split[2]}.");
                        count++;
                    }
                }
            }

            command = Console.ReadLine();
        }

        
        foreach (var item in guests.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
        }
        Console.WriteLine($"Unliked meals: {count}");
    }
}
