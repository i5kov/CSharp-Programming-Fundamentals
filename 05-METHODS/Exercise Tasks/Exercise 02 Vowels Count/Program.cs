using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        int result = VowelsCountInString(input);
        Console.WriteLine(result);
    }

    private static int VowelsCountInString(string s)
    {
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (isVowel(s[i]))
            {
                count++; 
            }
        }

        return count;
    }

    private static bool isVowel(char c)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
        return vowels.Contains(c);
    }
}