using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Battle_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> people = new Dictionary<string, List<int>>();
            string command = Console.ReadLine();

            while (command != "Results")
            {
                string[] split = command.Split(":");

                if (command.Contains("Add"))
                {
                    string personName = split[1];
                    int health = int.Parse(split[2]);
                    int energy = int.Parse(split[3]);

                    if (!people.ContainsKey(personName))
                    {
                        people.Add(personName, new List<int> { health, energy });
                    }
                    else
                    {
                        people[personName][0] += health;
                    }
                }
                else if (command.Contains("Attack"))
                {
                    string attackerName = split[1];
                    string defenderName = split[2];
                    int damage = int.Parse(split[3]);

                    if (people.ContainsKey(attackerName) && people.ContainsKey(defenderName))
                    {
                        people[defenderName][0] -= damage;
                        people[attackerName][1]--;
                        if (people[defenderName][0] <= 0)
                        {
                            people.Remove(defenderName);
                            Console.WriteLine($"{defenderName} was disqualified!");
                        }
                        if (people[attackerName][1] <= 0)
                        {
                            people.Remove(attackerName);
                            Console.WriteLine($"{attackerName} was disqualified!");
                        }
                    }

                }
                else if (command.Contains("Delete"))
                {
                    string username = split[1];
                    if (username == "All")
                    {
                        foreach (var person in people)
                        {
                            people.Remove(person.Key);
                        }
                    }
                    else
                    {
                        people.Remove(username);
                    }
                }

                command = Console.ReadLine();
            }

            people = people
                .OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"People count: {people.Count}");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key} - {person.Value[0]} - {person.Value[1]}");
            }
        }
    }
}
