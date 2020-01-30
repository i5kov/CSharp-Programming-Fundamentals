using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        string repeatedString = RepeatString(input, count);
        Console.WriteLine(repeatedString);
    }

    private static string RepeatString(string s, int count)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            result.Append(s);
        }

        return result.ToString();
    }
}