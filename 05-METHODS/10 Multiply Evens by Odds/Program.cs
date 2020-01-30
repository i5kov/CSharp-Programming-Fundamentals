using System;

class Program
{
    static void Main()
    {
        int inputNumber = Math.Abs(int.Parse(Console.ReadLine()));
        int evenSum = EvenNumbersSum(inputNumber);
        int oddSum = OddNumbersSum(inputNumber);
        int result = GetMultipleOfEvenAndOdds(evenSum, oddSum);
        Console.WriteLine(result);
    }

    private static int EvenNumbersSum(int number)
    {
        int evenSum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                evenSum += digit;
            }
            number /= 10;
        }
        return evenSum;
    }

    private static int OddNumbersSum(int number)
    {
        int oddSum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 != 0)
            {
                oddSum += digit;
            }
            number /= 10;
        }
        return oddSum;
    }

    private static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
    {
        return evenSum * oddSum;
    }
}