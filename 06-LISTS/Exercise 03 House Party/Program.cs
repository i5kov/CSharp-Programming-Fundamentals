using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int numbersOfCommand = int.Parse(Console.ReadLine());
        List<string> guestList = new List<string>();
        

        for (int i = 0; i < numbersOfCommand; i++)
        {
            string[] command = Console.ReadLine().Split();
            string guestName = command[0];
            if (command.Contains("not"))
            {
                if (IsNameAvailableInTheGuestList(guestList, guestName))
                {
                    guestList.Remove(guestName);
                }
                else
                {
                    Console.WriteLine($"{guestName} is not in the list!");
                }
            }
            else
            {
                if (IsNameAvailableInTheGuestList(guestList, guestName))
                {
                    Console.WriteLine($"{guestName} is already in the list!");
                }
                else
                {
                    guestList.Add(guestName);
                }
            }

        }

        foreach (var name in guestList)
        {
            Console.WriteLine(name);
        }
    }

    static bool IsNameAvailableInTheGuestList(List<string> guestList, string nameForCheck)
    {
        foreach (var guestName in guestList)
        {
            if (guestName == nameForCheck)
            {
                return true;
            }
        }
        return false;
    }
}