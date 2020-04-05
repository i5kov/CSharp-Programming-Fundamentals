using System;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            bool isDead = false;
            int bestRoom = 0;
            string[] rooms = Console.ReadLine().Split("|");

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] input = rooms[i].Split();
                string command = input[0];
                int value = int.Parse(input[1]);

                if (command.Contains("potion"))
                {
                    int currentHealt = health;
                    health += value;
                    if (health > 100)
                    {
                        health = 100;
                        int amount = 100 - currentHealt;
                        Console.WriteLine($"You healed for {amount} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {value} hp.");
                    }
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command.Contains("chest"))
                {
                    bitcoins += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                else
                {
                    health -= value;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        isDead = true;
                        bestRoom = i + 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                }

            }

            if (isDead)
            {
                Console.WriteLine($"Best room: {bestRoom}");
            }
            else
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}