using System;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        string operation = Console.ReadLine();
        int secondNumber = int.Parse(Console.ReadLine());
        int result = Calculate(firstNumber, operation, secondNumber);
        Console.WriteLine(result);
    }

    private static int Calculate(int firstNumber, string operation, int secondNumber)
    {
        int result = 0;
        switch (operation)
        {
            case "/":
                result = firstNumber / secondNumber;
                break;
            case "*":
                result = firstNumber * secondNumber;
                break;
            case "+":
                result = firstNumber + secondNumber;
                break;
            case "-":
                result = firstNumber - secondNumber;
                break;
        }
        return result;
    }
}