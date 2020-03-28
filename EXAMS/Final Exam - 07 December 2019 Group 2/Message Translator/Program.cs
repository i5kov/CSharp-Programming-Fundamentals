using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Regex regex = new Regex(@"!([A-Z][a-z]{2,})!:\[([A-z]{8,})\]");

        for (int i = 0; i < n; i++)
        {
            string commandMessage = Console.ReadLine();
            Match match = regex.Match(commandMessage);

            if (match.Success)
            {
                Console.Write($"{match.Groups[1]}: ");
                Group group = match.Groups[2];
                foreach (var item in match.Groups[2].Value)
                {
                    Console.Write($"{(int)item} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The message is invalid");
            }
        }
    }
}