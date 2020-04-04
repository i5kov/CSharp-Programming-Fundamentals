using System;

class SpecialNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            int n = i;
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit;
                n /= 10;
            }

            if (sum == 5 || sum == 7 || sum == 11)
            {
                Console.WriteLine($"{i} -> True");
            }
            else
            {
                Console.WriteLine($"{i} -> False");
            }
        }
    }
}