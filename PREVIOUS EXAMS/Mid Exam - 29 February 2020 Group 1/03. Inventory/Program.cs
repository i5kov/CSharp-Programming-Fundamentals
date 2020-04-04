using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] split = command.Split(" - ");
                string item = split[1];

                if (command.Contains("Collect"))
                {
                    if (!inventory.Contains(item))
                    {
                        inventory.Add(item);
                    }
                }
                if (command.Contains("Drop"))
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }
                }
                if (command.Contains("Combine Items"))
                {
                    string oldItem = split[1].Split(":")[0];
                    string newItem = split[1].Split(":")[1];
                    if (inventory.Contains(oldItem))
                    {
                        int index = inventory.IndexOf(oldItem);
                        inventory.Insert(index + 1, newItem);
                    }

                }
                if (command.Contains("Renew"))
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", inventory));

        }
    }
}
