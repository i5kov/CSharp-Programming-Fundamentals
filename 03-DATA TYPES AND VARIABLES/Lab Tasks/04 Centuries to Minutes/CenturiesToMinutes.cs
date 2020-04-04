using System;

class CenturiesToMinutes
{
    static void Main()
    {
        int century = int.Parse(Console.ReadLine());
        int years = century * 100;
        double days = Math.Floor(years * 365.2422);
        int hours = (int)days * 24;
        int minutes = hours * 60;

        Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}