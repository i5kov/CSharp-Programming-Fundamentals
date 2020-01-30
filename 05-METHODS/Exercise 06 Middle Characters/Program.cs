using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string result = MiddleCharacters(input);
        Console.WriteLine(result);
    }

    private static string MiddleCharacters(string s)
    {
        string middleCharacters = string.Empty;
        if (s.Length % 2 == 0)
        {
            middleCharacters = s[s.Length / 2 - 1] + "" + s[s.Length / 2];
        }
        else
        {
            middleCharacters = "" + s[s.Length / 2];
        }

        return middleCharacters;
    }
}