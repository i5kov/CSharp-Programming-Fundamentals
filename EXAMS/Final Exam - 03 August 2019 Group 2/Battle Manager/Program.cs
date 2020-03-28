using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();
        Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

        while (command != "Results")
        {
            string[] split = command.Split(":");
            if (command.Contains("Add"))
            {
                if (!dict.ContainsKey(split[1]))
                {
                    dict.Add(split[1], new List<int> { int.Parse(split[2]), int.Parse(split[3]) });
                }
                else
                {
                    dict[split[1]][0] += int.Parse(split[2]);
                }
            }
            if (command.Contains("Attack"))
            {
                string attackerName = split[1];
                string defenderName = split[2];
                int damage = int.Parse(split[3]);

                if (dict.ContainsKey(attackerName) && dict.ContainsKey(defenderName))
                {
                    dict[defenderName][0] -= damage;
                    if (dict[defenderName][0] <= 0)
                    {
                        dict.Remove(defenderName);
                        Console.WriteLine($"{defenderName} was disqualified!");
                    }
                    dict[attackerName][1]--;
                    if (dict[attackerName][1] == 0)
                    {
                        dict.Remove(attackerName);
                        Console.WriteLine($"{attackerName} was disqualified!");
                    }
                }

            }
            if (command.Contains("Delete"))
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
                    dict.Remove(split[1]);
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"People count: {dict.Count}");
        foreach (var item in dict.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} - {item.Value[0]} - {item.Value[1]}");
        }
    }
}