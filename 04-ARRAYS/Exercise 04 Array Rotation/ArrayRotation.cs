using System;
using System.Linq;

class ArrayRotation
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int length = numbers.Length;
        int rotations = int.Parse(Console.ReadLine());

        for (int i = 0; i < rotations; i++)
        {
            int firstElement = numbers[0];
            for (int j = 0; j < length - 1; j++)
            {
                numbers[j] = numbers[j + 1];
            }
            numbers[length - 1] = firstElement;
        }

        Console.WriteLine(string.Join(' ', numbers));
    }
}