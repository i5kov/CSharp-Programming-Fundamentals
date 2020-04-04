using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Regex regex = new Regex(@"");

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            Match match = regex.Match(input);

            if (match.Success)
            {

            }
            else
            {

            }
        }
    }
}