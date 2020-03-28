using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Regex regex = new Regex(@"\|([A-Z]{4,})\|:#([A-Za-z]+ [A-Za-z]+)#");

        for (int i = 0; i < n; i++)
        {
            string nameTitle = Console.ReadLine();
            Match match = regex.Match(nameTitle);

            if (match.Success)
            {
                Console.WriteLine($"{match.Groups[1]}, The {match.Groups[2]}");
                Console.WriteLine($">> Strength: {match.Groups[1].Length}");
                Console.WriteLine($">> Armour: {match.Groups[2].Length}");
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }
    }
}