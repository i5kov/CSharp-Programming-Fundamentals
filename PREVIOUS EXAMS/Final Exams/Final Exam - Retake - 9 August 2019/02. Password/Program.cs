using System;
using System.Text.RegularExpressions;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^([\w|\W]+)>([0-9]{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1$");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string password = Console.ReadLine();
                Match match = regex.Match(password);

                if (match.Success)
                {
                    string group1 = match.Groups[2].Value;
                    string group2 = match.Groups[3].Value;
                    string group3 = match.Groups[4].Value;
                    string group4 = match.Groups[5].Value;
                    Console.WriteLine($"Password: {group1+group2+group3+group4}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
