using System;

class Program
{
    static void Main()
    {
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());
        PrintChars(firstChar, secondChar);
    }

    private static void PrintChars(char char1, char char2)
    {
        int start = Math.Min(char1, char2);
        int end = Math.Max(char1, char2);

        for (int i = start + 1; i < end; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}