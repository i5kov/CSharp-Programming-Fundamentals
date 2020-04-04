using System;
using System.Linq;

class MaxSequenceEqualElements
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        int counter = 0;
        int maxSequence = 0;
        int start = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                counter++;
                if (counter > maxSequence)
                {
                    start = i - counter;
                    maxSequence = counter;
                }
            }
            else
            {
                counter = 0;
            }
        }

        for (int i = start + 1; i <= start + maxSequence + 1; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}