using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();

        Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

        while (command != "Statistics")
        {
            string[] split = command.Split("->");
            if (command.Contains("Add"))
            {
                if (!users.ContainsKey(split[1]))
                {
                    users.Add(split[1], new List<string>());
                }
                else
                {
                    Console.WriteLine($"{split[1]} is already registered");
                }
            }
            if (command.Contains("Send"))
            {
                users[split[1]].Add(split[2]);
            }
            if (command.Contains("Delete"))
            {
                if (users.ContainsKey(split[1]))
                {
                    users.Remove(split[1]);
                }
                else
                {
                    Console.WriteLine($"{split[1]} not found!");
                }
            }
            command = Console.ReadLine();
        }

        Console.WriteLine($"Users count: {users.Count}");

        foreach (var item in users.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToList())
        {
            Console.WriteLine(item.Key);
            foreach (var mail in item.Value)
            {
                Console.WriteLine($" - {mail}");
            }
        }
    }
}