using System;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        double divisionOfFactorials = DivideNumbers(firstNumber, secondNumber);
        Console.WriteLine($"{divisionOfFactorials:f2}");
    }

    private static long Factorial(int number)
    {
        long factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    private static double DivideNumbers(int firstNumber, int secondNumber)
    {
        return Factorial(firstNumber) * 1.0 / Factorial(secondNumber);
    }
}