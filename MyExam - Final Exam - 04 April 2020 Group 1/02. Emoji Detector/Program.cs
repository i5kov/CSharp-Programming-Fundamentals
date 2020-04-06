using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(::|\*\*)([A-Z][a-z]{2,})\1");
            Regex numbersRegex = new Regex(@"\d+");
            string input = Console.ReadLine();
            
            BigInteger coolTreshhold = 1;
            int sum = 0;

            MatchCollection numberMatches = numbersRegex.Matches(input);
            MatchCollection matches = regex.Matches(input);

            for (int i = 0; i < numberMatches.Count; i++)
            {
                string value = numberMatches[i].Value;

                for (int j = 0; j < value.Length; j++)
                {
                    coolTreshhold *= (value[j] - '0');
                }
            }
            Console.WriteLine($"Cool threshold: {coolTreshhold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            
            for (int i = 0; i < matches.Count; i++)
            {
                Match currentMatch = matches[i];
                string result = currentMatch.Groups[2].Value;
                foreach (var s in result)
                {
                    sum += (int)s;
                }

                if (sum > coolTreshhold)
                {
                    Console.WriteLine(currentMatch);
                }
                sum = 0;
            }
        }
    }
}
