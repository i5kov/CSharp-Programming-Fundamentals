using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        Dictionary<string, string> registered = new Dictionary<string, string>();

        for (int i = 0; i < lines; i++)
        {
            string[] input = Console.ReadLine().Split();
            string command = input[0];
            string username = input[1];

            if (command == "register")
            {
                
                string licensePlateNumber = input[2];

                if (!registered.ContainsKey(username))
                {
                    registered.Add(username, licensePlateNumber);
                    Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                }
            }
            else
            {
                if (!registered.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
                else
                {
                    registered.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
            }
        }

        foreach (var item in registered)
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }
    }
}