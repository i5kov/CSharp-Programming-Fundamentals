using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int house = 0;

            while (command != "Love!")
            {
                string[] split = command.Split();
                int jumpLen = int.Parse(split[1]);
                house += jumpLen;

                if (house >= neighborhood.Length)
                {
                    house = 0;
                }
                if (neighborhood[house] == 0)
                {
                    Console.WriteLine($"Place {house} already had Valentine's day.");
                }
                else
                {
                    neighborhood[house] -= 2;
                    if (neighborhood[house] == 0)
                    {
                        Console.WriteLine($"Place {house} has Valentine's day.");
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {house}.");
            int count = 0;

            for (int i = 0; i < neighborhood.Length; i++)
            {
                if (neighborhood[i] > 0)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {count} places.");
            }
        }
    }
}