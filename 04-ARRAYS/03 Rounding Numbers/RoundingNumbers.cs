using System;
using System.Linq;

class RoundingNumbers
{
    static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        foreach (double number in numbers)
        {
            double roundedNumber = (int)Math.Round(number, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{number} => {roundedNumber}");
        }
    }
}