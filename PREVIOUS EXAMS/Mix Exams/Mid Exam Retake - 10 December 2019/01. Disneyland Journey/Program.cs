using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeyCost = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double save = 0;
            for (int i = 1; i <= months; i++)
            {
                if (i != 1 && i % 2 != 0)
                {
                    save  = save - (save * 0.16);
                }
                else if (i % 4 == 0)
                {
                    save = save + (save * 0.25);
                }

                save = save + (journeyCost * 0.25);
            }
            

            if (save - journeyCost > 0)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {save - journeyCost:F2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {journeyCost - save:F2}lv. more.");
            }
        }
    }
}