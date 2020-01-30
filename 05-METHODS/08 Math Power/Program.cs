using System;

class Program
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double power = int.Parse(Console.ReadLine());
        double result = RaiseToPower(number, power);
        Console.WriteLine(result);
    }

    private static double RaiseToPower(double number, double power)
    {
        return Math.Pow(number, power);
    }
}