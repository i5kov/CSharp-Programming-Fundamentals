using System;
using System.Text.RegularExpressions;

namespace _02._Message_Decrypter
{
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
                    string tag = match.Groups[2].Value;
                    char numGroup1 = (char)int.Parse(match.Groups[3].Value);
                    char numGroup2 = (char)int.Parse(match.Groups[4].Value);
                    char numGroup3 = (char)int.Parse(match.Groups[5].Value);

                    Console.WriteLine($"{tag}: {numGroup1}{numGroup2}{numGroup3}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
