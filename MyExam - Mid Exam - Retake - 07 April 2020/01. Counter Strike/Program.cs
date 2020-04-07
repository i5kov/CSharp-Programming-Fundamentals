using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int wonBattle = 0;
            bool isLost = false;

            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (initialEnergy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattle} won battles and {initialEnergy} energy");
                    isLost = true;
                    break;
                }
                initialEnergy -= distance;
                wonBattle++;

                if (wonBattle % 3 == 0)
                {
                    initialEnergy += wonBattle;
                }
                command = Console.ReadLine();
            }

            if (!isLost)
            {
                Console.WriteLine($"Won battles: {wonBattle}. Energy left: {initialEnergy}");
            }
        }
    }
}
