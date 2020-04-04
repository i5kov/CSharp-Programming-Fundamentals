using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday",
                               "Thursday", "Friday", "Saturday", "Sunday"};

        if (day > 0 && day < 8)
        {
            Console.WriteLine(daysOfWeek[day - 1]);
        } 
        else
        {
            Console.WriteLine("Invalid day!");
        }
    }
}