using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            while (command != "Sail")
            {
                string[] split = command.Split("||");
                string city = split[0];
                int population = int.Parse(split[1]);
                int gold = int.Parse(split[2]);

                if (!dict.ContainsKey(city))
                {
                    dict.Add(city, new List<int> { population, gold });
                }
                else
                {
                    dict[city][0] += population;
                    dict[city][1] += gold;
                }
                command = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();

            while (secondCommand != "End")
            {
                string[] split = secondCommand.Split("=>");
                if (secondCommand.Contains("Plunder"))
                {
                    string town = split[1];
                    int people = int.Parse(split[2]);
                    int gold = int.Parse(split[3]);

                    if (dict.ContainsKey(town))
                    {
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                        dict[town][0] -= people;
                        dict[town][1] -= gold;

                        if (dict[town][0] <= 0 || dict[town][1] <= 0)
                        {
                            dict.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                        }
                    }
                }
                else if (secondCommand.Contains("Prosper"))
                {
                    string town = split[1];
                    int gold = int.Parse(split[2]);

                    if (dict.ContainsKey(town))
                    {
                        if (gold <= 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            dict[town][1] += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {dict[town][1]} gold.");
                        }
                    }
                }
                secondCommand = Console.ReadLine();
            }

            dict = dict
                .OrderByDescending(x => x.Value[1])
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            if (dict.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {dict.Count} wealthy settlements to go to:");
                foreach (var item in dict)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
