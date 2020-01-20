using System;


class Vacation
{
    static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        string group = Console.ReadLine();
        string day = Console.ReadLine();
        decimal price = 0.00m;

        if (group == "Students")
        {
            if (day == "Friday")
            {
                price = 8.45m;
            }
            else if (day == "Saturday")
            {
                price = 9.80m;
            }
            else if (day == "Sunday")
            {
                price = 10.46m;
            }
        }
        else if (group == "Business")
        {
            if (day == "Friday")
            {
                price = 10.90m;
            }
            else if (day == "Saturday")
            {
                price = 15.60m;
            }
            else if (day == "Sunday")
            {
                price = 16;
            }
        }
        else if (group == "Regular")
        {
            if (day == "Friday")
            {
                price = 15;
            }
            else if (day == "Saturday")
            {
                price = 20;
            }
            else if (day == "Sunday")
            {
                price = 22.50m;
            }
        }
        if (people >= 30 && group == "Students")
        {
            price *= 0.85m;
        }
        else if (people >= 100 && group == "Business")
        {
            people -= 10;
        }
        else if ((people >= 10 && people <= 20) && group == "Regular")
        {
            price *= 0.95m;
        }
        Console.WriteLine($"Total price: {(people * price):f2}");
    }
}