using System;

class SumOfChars
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < lines; i++)
        {
            char c = char.Parse(Console.ReadLine());
            sum += c;
        }

        Console.WriteLine($"The sum equals: {sum}");
    }
}