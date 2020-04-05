using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> users = new Dictionary<string, List<int>>();
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] split = command.Split("=");
                if (command.Contains("Add"))
                {
                    string username = split[1];
                    int sentEmails = int.Parse(split[2]);
                    int receivedEmails = int.Parse(split[3]);

                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new List<int> { sentEmails, receivedEmails });
                    }
                }
                else if (command.Contains("Message"))
                {
                    string sender = split[1];
                    string receiver = split[2];

                    if (users.ContainsKey(sender) && users.ContainsKey(receiver))
                    {
                        users[sender][0]++;
                        users[receiver][1]++;
                        if (users[sender][0] + users[sender][1] >= capacity)
                        {
                            users.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        if (users[receiver][0] + users[receiver][1] >= capacity)
                        {
                            users.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                    }
                }
                else if (command.Contains("Empty"))
                {
                    string username = split[1];

                    if (username == "All")
                    {
                        foreach (var user in users)
                        {
                            users.Remove(user.Key);
                        }
                    }
                    else
                    {
                        users.Remove(username);
                    }
                }

                command = Console.ReadLine();
            }

            users = users
                .OrderByDescending(x => x.Value[1])
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Users count: {users.Count}");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} - {user.Value[0] + user.Value[1]}");
            }
        }
    }
}
