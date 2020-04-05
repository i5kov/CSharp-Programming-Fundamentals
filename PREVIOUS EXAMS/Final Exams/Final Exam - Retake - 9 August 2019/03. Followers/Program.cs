using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> users = new Dictionary<string, List<int>>();
            string command = Console.ReadLine();

            while (command != "Log out")
            {
                string[] split = command.Split(": ");
                string username = split[1];

                if (command.Contains("New follower"))
                {
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new List<int>() { 0, 0 });
                    }
                }
                else if (command.Contains("Like"))
                {
                    int likes = int.Parse(split[2]);
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new List<int> { likes, 0 });
                    }
                    else
                    {
                        users[username][0] += likes;
                    }
                }
                else if (command.Contains("Comment"))
                {
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new List<int> { 0, 1 });
                    }
                    else
                    {
                        users[username][1]++;
                    }
                }
                else if (command.Contains("Blocked"))
                {
                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                }
                command = Console.ReadLine();
            }

            users = users
                .OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"{users.Count} followers");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}: {user.Value[0] + user.Value[1]}");
            }
        }
    }
}
