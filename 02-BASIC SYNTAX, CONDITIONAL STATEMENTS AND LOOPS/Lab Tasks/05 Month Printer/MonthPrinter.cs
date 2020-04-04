using System;


class MonthPrinter
{
    static void Main()
    {
        int monthAsNumber = int.Parse(Console.ReadLine());

        string[] months = {"January", "February", "March", "April",
                           "May", "June", "July", "August",
                           "September", "October", "November", "December"};

        if (monthAsNumber > 0 && monthAsNumber <= 12)
        {
            Console.WriteLine(months[monthAsNumber - 1]);
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }
}