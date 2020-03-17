using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split();
        StringBuilder result = new StringBuilder();

        foreach (string currentWord in words)
        {
            for (int i = 0; i < currentWord.Length; i++)
            {
                result.Append(currentWord);
            }
        }

        Console.WriteLine(result);
    }
}