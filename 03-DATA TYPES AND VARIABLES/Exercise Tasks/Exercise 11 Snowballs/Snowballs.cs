using System;
using System.Numerics;

class Snowballs
{
    static void Main()
    {
        int snowballs = int.Parse(Console.ReadLine());

        BigInteger maxValue = 0;
        string bestResult = "";

        for (int i = 0; i < snowballs; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

            if (snowballValue >= maxValue)
            {
                maxValue = snowballValue;
                string result = ($"{snowballSnow} : {snowballTime} = {maxValue} ({snowballQuality})");
                bestResult = result;
            }
        }
        Console.WriteLine(bestResult);
    }
}