using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, int> users = new Dictionary<string, int>();
        Dictionary<string, int> submissions = new Dictionary<string, int>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "exam finished")
            {
                break;
            }
            string[] splitInput = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
            string user = splitInput[0];

            if (!input.Contains("banned"))
            {
                string lang = splitInput[1];
                int points = int.Parse(splitInput[2]);

                if (!users.ContainsKey(user))
                {
                    users.Add(user, points);
                    if (!submissions.ContainsKey(lang))
                    {
                        submissions.Add(lang, 1);
                    }
                    else
                    {
                        submissions[lang]++;
                    }
                    
                }
                else
                {
                    if (points >= users[user])
                    {
                        users[user] = points;
                    }
                    submissions[lang]++;
                }

            }
            else
            {
                users.Remove(user);
            }
        }
        Console.WriteLine("Results:");
        foreach (var item in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} | {item.Value}");
        }

        Console.WriteLine("Submissions:");
        foreach (var item in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

    }
}