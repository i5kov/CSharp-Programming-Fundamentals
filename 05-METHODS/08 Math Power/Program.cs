using System;

class Program
{
    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        decimal result = RaiseToPower(number, power);
        Console.WriteLine(result);
    }

    private static decimal RaiseToPower(decimal number, int power)
    {
        decimal result = 1M;
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }
        return result;
    }
}