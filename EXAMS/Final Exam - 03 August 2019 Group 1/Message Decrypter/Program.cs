using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Regex regex = new Regex(@"^(\$|%)([A-Z][a-z]{2,})\1: \[([0-9]+)\]\|\[([0-9]+)\]\|\[([0-9]+)\]\|$");

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            Match match = regex.Match(input);

            if (match.Success)
            {
                char first = (char)int.Parse(match.Groups[3].Value);
                char second = (char)int.Parse(match.Groups[4].Value);
                char third = (char)int.Parse(match.Groups[5].Value);
                Console.WriteLine($"{match.Groups[2]}: {first}{second}{third}");
            }
            else
            {
                Console.WriteLine("Valid message not found!");
            }
        }
    }
}