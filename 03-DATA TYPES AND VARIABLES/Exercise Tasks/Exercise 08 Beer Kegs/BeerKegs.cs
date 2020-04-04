using System;

class BeerKegs
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        string biggestKegModel = "";
        double maxVolume = 0;

        for (int i = 0; i < lines; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double currentKegVolume = Math.Pow(radius, 2) * Math.PI * height;

            if (currentKegVolume >= maxVolume)
            {
                maxVolume = currentKegVolume;
                biggestKegModel = model;
            }
        }
        Console.WriteLine(biggestKegModel);
    }
}