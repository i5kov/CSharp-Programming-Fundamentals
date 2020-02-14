using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
        int maxCapacityOfWagon = int.Parse(Console.ReadLine());

        while (true)
        {
            string[] command = Console.ReadLine().Split();
            if (command.Length == 1)
            {
                if (command[0] == "end")
                {
                    break;
                }
                else
                {
                    int morePassengers = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + morePassengers <= maxCapacityOfWagon)
                        {
                            wagons[i] += morePassengers;
                            break;
                        }
                    }
                }
            }
            else
            {
                int morePassengers = int.Parse(command[1]);
                wagons.Add(morePassengers);
            }  
        }
        Console.WriteLine(string.Join(" ", wagons));
    }
}