using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Regex regex = new Regex(@"([\*|@])([A-Z][a-z]{2,})\1: \[([A-z]+)\]\|\[([A-z]+)\]\|\[([A-z]+)\]\|$");

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            Match match = regex.Match(input);

            if (match.Success)
            {
                int first = (int)char.Parse(match.Groups[3].Value);
                int second = (int)char.Parse(match.Groups[4].Value);
                int third = (int)char.Parse(match.Groups[5].Value);
                Console.WriteLine($"{match.Groups[2]}: {first} {second} {third}");
                
            }
            else
            {
                Console.WriteLine("Valid message not found!");
            }
        }
    }
}