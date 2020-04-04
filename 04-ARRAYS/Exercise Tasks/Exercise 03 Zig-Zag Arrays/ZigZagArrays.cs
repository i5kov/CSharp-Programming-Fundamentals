using System;
using System.Linq;

class ZigZagArrays
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        int[] firstArr = new int[lines];
        int[] secondArr = new int[lines];

        for (int i = 0; i < lines; i++)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (i % 2 == 0)
            {
                firstArr[i] = numbers[0];
                secondArr[i] = numbers[1];
            }
            else
            {
                secondArr[i] = numbers[0];
                firstArr[i] = numbers[1];
            }
        }

        Console.WriteLine(string.Join(' ', firstArr));
        Console.WriteLine(string.Join(' ', secondArr));
    }
}