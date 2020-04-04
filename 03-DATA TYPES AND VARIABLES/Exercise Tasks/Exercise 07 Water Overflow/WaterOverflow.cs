using System;

class WaterOverflow
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        int waterTank = 255;

        int addedWater = 0;
        for (int i = 0; i < lines; i++)
        {
            int quantity = int.Parse(Console.ReadLine());
            addedWater += quantity;

            if (addedWater > waterTank)
            {
                Console.WriteLine("Insufficient capacity!");
                addedWater -= quantity;
            }
        }
        Console.WriteLine(addedWater);
    }
}