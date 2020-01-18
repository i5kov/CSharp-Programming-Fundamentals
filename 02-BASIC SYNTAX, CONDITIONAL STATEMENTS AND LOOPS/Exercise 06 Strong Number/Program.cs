using System;


class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int inputNumber = number;

        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;

            int factorial = 1;
            
            for (int i = 1; i <= digit; i++)
            {
                factorial *= i;
            }

            sum += factorial;
            number /= 10;
        }

        if (sum == inputNumber)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
            
    }
}