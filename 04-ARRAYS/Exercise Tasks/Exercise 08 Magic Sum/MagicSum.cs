using System;
using System.Linq;

class MagicSum
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentElement = numbers[i];
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if ((currentElement + numbers[j]) == number)
                {
                    Console.WriteLine($"{currentElement} {numbers[j]}");
                }
            }

        }
    }
}