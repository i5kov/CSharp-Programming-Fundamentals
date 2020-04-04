using System;

class BackIn30Minutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 30;

        if (minutes > 59)
        {
            hours++;
            minutes -= 60;
        }
        else
        {
            hours = 0;
        }

        if (minutes < 10)
        {
            Console.WriteLine($"{hours}:{minutes:00}");
        }
        else
        {
            Console.WriteLine($"{hours}:{minutes}");
        }
    }
}