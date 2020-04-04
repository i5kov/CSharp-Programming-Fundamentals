using System;

class Program
{
    static void Main(string[] args)
    {
        string[] bannedWords = Console.ReadLine().Split(", ");
        string text = Console.ReadLine();

        foreach (string currentWord in bannedWords)
        {
            text = text.Replace(currentWord, new string('*', currentWord.Length));
        }

        Console.WriteLine(text);
    }
}