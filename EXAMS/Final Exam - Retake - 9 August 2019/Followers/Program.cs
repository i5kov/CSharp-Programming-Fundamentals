using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();

        Dictionary<string, List<int>> users = new Dictionary<string, List<int>>();

        while (command != "Log out")
        {
            string[] split = command.Split(": ");
            if (command.Contains("New follower"))
            {
                if (!users.ContainsKey(split[1]))
                {
                    users.Add(split[1], new List<int> {0,0}); //likes, comments
                }
            }
            if (command.Contains("Like"))
            {
                if (!users.ContainsKey(split[1]))
                {
                    users.Add(split[1], new List<int> { int.Parse(split[2]), 0 });
                }
                else
                {
                    users[split[1]][0] += int.Parse(split[2]);
                }
            }
            if (command.Contains("Comment"))
            {
                if (!users.ContainsKey(split[1]))
                {
                    users.Add(split[1], new List<int> {0,1});
                }
                else
                {
                    users[split[1]][1] += 1;
                }
            }
            if (command.Contains("Blocked"))
            {
                if (users.ContainsKey(split[1]))
                {
                    users.Remove(split[1]);
                }
                else
                {
                    Console.WriteLine($"{split[1]} doesn't exist.");
                }
            }
            command = Console.ReadLine();
        }

        Console.WriteLine($"{users.Count} followers");

        users = users.OrderByDescending(x => x.Value[0])
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var item in users)
        {
            Console.WriteLine($"{item.Key}: {item.Value[0] + item.Value[1]}");
        }

    }
}