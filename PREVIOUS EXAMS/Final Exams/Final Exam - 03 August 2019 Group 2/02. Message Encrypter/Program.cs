using System;
using System.Text.RegularExpressions;

namespace _02._Message_Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(\*|@)([A-Z][a-z]{2,})\1: \[([A-z]+)\]\|\[([A-z]+)\]\|\[([A-z]+)\]\|$");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                Match match = regex.Match(message);

                if (match.Success)
                {
                    string tag = match.Groups[2].Value;
                    int firstNumber = (int)char.Parse(match.Groups[3].Value);
                    int secondNumber = (int)char.Parse(match.Groups[4].Value);
                    int thirdNumber = (int)char.Parse(match.Groups[5].Value);

                    Console.WriteLine($"{tag}: {firstNumber} {secondNumber} {thirdNumber} ");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
