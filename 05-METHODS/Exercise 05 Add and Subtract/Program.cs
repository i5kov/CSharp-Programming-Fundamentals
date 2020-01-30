using System;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int result = Subtract(firstNumber, secondNumber, thirdNumber);
        Console.WriteLine(result);
    }

    private static int Sum(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    private static int Subtract(int firstNumber, int secondNumber, int thirdNumber)
    {
        return Sum(firstNumber, secondNumber) - thirdNumber;
    }
}