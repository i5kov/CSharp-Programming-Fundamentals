using System;


class Vacation
{
    static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        string group = Console.ReadLine().ToLower();
        string day = Console.ReadLine().ToLower();
        decimal price = 0.00m;

        if (group == "students")
        {
            if (day == "friday")
            {
                price = 8.45m;
            }
            else if (day == "saturday")
            {
                price = 9.80m;
            }
            else if (day == "sunday")
            {
                price = 10.46m;
            }
        }
        else if (group == "business")
        {
            if (day == "friday")
            {
                price = 10.90m;
            }
            else if (day == "saturday")
            {
                price = 15.60m;
            }
            else if (day == "sunday")
            {
                price = 16;
            }
        }
        else if (group == "regular")
        {
            if (day == "friday")
            {
                price = 15;
            }
            else if (day == "saturday")
            {
                price = 20;
            }
            else if (day == "sunday")
            {
                price = 22.50m;
            }
        }
        if (people >= 30 && group == "students")
        {
            price *= 0.85m;
        }
        else if (people >= 100 && group == "business")
        {
            people -= 10;
        }
        else if ((people >= 10 && people <= 20) && group == "regular")
        {
            price *= 0.95m;
        }
        Console.WriteLine($"Total price: {(people * price):f2}");
    }
}