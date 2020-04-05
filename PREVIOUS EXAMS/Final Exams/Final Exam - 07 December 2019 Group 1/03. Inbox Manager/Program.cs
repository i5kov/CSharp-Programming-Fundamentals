using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] split = command.Split("->");
                string username = split[1];

                if (command.Contains("Add"))
                {
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                }
                else if (command.Contains("Send"))
                {
                    string email = split[2];
                    users[username].Add(email);
                }
                else if (command.Contains("Delete"))
                {
                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");
            users = users
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var user in users)
            {
                Console.WriteLine(user.Key);
                foreach (var email in user.Value)
                {
                    Console.WriteLine($"- {email}");
                }
            }
        }
    }
}
