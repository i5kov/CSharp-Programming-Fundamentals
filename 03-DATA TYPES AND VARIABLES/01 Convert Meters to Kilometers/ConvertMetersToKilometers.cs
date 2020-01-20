using System;

class ConvertMetersToKilometers
{
    static void Main()
    {
        int meters = int.Parse(Console.ReadLine());
        double metersToKilometers = meters * 0.001;

        Console.WriteLine($"{metersToKilometers:f2}");
    }
}