using System;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"(\w+|\W+)>([0-9]{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1$");

            for (int i = 0; i < n; i++)
            {
                string password = Console.ReadLine();
                Match match = regex.Match(password);

                if (match.Success)
                {
                    Console.WriteLine($"Password: {match.Groups[2]}{match.Groups[3]}{match.Groups[4]}{match.Groups[5]}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
