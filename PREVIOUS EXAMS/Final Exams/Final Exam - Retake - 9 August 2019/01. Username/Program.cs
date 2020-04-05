using System;
using System.Linq;

namespace _01._Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Sign up")
            {
                string[] split = command.Split();
                if (command.Contains("Case lower"))
                {
                    username = username.ToLower();
                    Console.WriteLine(username);
                }
                else if (command.Contains("Case upper"))
                {
                    username = username.ToUpper();
                    Console.WriteLine(username);
                }
                else if (command.Contains("Reverse"))
                {
                    int startIndex = int.Parse(split[1]);
                    int endIndex = int.Parse(split[2]);
                    if (startIndex >= 0 && startIndex <= username.Length && endIndex >= 0 && endIndex <= username.Length)
                    {
                        string substring = username.Substring(startIndex, (endIndex - startIndex) + 1);
                        Console.WriteLine(string.Join("", substring.Reverse()));
                    }
                }
                else if (command.Contains("Cut"))
                {
                    string substring = split[1];
                    if (username.Contains(substring))
                    {
                        username = username.Remove(username.IndexOf(substring), substring.Length);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {substring}.");
                    }
                }
                else if (command.Contains("Replace"))
                {
                    char c = char.Parse(split[1]);
                    username = username.Replace(c, '*');
                    Console.WriteLine(username);
                }
                else if (command.Contains("Check"))
                {
                    char c = char.Parse(split[1]);
                    if (username.Contains(c))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {c}.");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
