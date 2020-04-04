using System;
using System.Linq;

class EqualArrays
{
    static void Main(string[] args)
    {
        int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int sum = 0;
        bool isEqual = true;

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                isEqual = false;
                Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                break;
            }
            sum += firstArray[i];
        }

        if (isEqual)
        {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}