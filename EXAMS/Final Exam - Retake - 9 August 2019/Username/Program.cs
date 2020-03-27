using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string username = Console.ReadLine();
        string command = Console.ReadLine();

        while (command != "Sign up")
        {
            string[] split = command.Split();
            if (command.Contains("Case"))
            {
                if (split[1] == "lower")
                {
                    username = username.ToLower();
                }
                else
                {
                    username = username.ToUpper();
                }
                Console.WriteLine(username);
            }
            if (command.Contains("Reverse"))
            {
                int startIndex = int.Parse(split[1]);
                int endIndex = int.Parse(split[2]);
                if ( (startIndex > 0 && startIndex <= username.Length) && (endIndex > 0 && endIndex <= username.Length))
                {
                    string reversed = string.Join("", string.Join("", username.Reverse()).Substring(startIndex, endIndex).Reverse());
                    Console.WriteLine(reversed);
                }
            }
            if (command.Contains("Cut"))
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
            if (command.Contains("Replace"))
            {
                username = username.Replace(split[1], "*");
                Console.WriteLine(username);
            }
            if (command.Contains("Check"))
            {
                if (username.Contains(split[1]))
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine($"Your username must contain {split[1]}.");
                }
            }


            command = Console.ReadLine();
        }
        
    }
}
