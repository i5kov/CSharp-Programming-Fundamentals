using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (IsSumDivisibleBy8(i) && IsHasOneOddDigit(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    private static bool IsSumDivisibleBy8(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }
        return sum % 8 == 0;
    }

    private static bool IsHasOneOddDigit(int number)
    {
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 != 0)
            {
                return true;
            }
            number /= 10;
        }
        return false;
    }
}