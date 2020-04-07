using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] split = command.Split();
                int index = int.Parse(split[1]);

                if (command.Contains("Shoot"))
                {
                    int power = int.Parse(split[2]);

                    if (index >= 0 && index < list.Count)
                    {
                        list[index] -= power;
                        if (list[index] <= 0)
                        {
                            list.RemoveAt(index);
                        }
                    }
                }
                else if (command.Contains("Add"))
                {
                    int value = int.Parse(split[2]);
                    if (index >= 0 && index < list.Count)
                    {
                        list.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid placement!");
                    }
                }
                else if (command.Contains("Strike"))
                {
                    int radius = int.Parse(split[2]);

                    if ( (index >= 0 && index < list.Count) && ( ((index - radius) >= 0) && ((index + radius) < list.Count)))
                    {
                        int itemBeforeRadius = list[index - radius];
                        int itemAfterRadiust = list[index + radius];
                        list.RemoveAt(index);
                        list.Remove(itemBeforeRadius);
                        list.Remove(itemAfterRadiust);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    
                    
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", list));
        }
    }
}
