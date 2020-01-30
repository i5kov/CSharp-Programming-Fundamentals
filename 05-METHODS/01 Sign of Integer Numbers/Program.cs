using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(signOfNumber(int.Parse(Console.ReadLine())));
    }

    static string signOfNumber(int number)
    {
        string result = string.Empty;
        if (number < 0)
        {
            result = $"The number {number} is negative.";
        } 
        else if (number > 0)
        {
            result = $"The number {number} is positive.";
        }
        else
        {
            result = "The number 0 is zero.";
        }
        return result;
    }
}