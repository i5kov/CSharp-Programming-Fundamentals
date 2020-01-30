using System;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int smallestNumber = SmallestNumber(firstNumber, secondNumber, thirdNumber);
        Console.WriteLine(smallestNumber);
    }

    private static int SmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
    {
        return Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber);
    }
}