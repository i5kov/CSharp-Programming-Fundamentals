using System;

class Program
{
    private static double coffeePrice = 1.50;
    private static double waterPrice = 1.00;
    private static double cokePrice = 1.40;
    private static double snacksPrice = 2.00;
    static void Main()
    {
        string product = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        PrintPrice(product, quantity);
    }

    private static void PrintPrice(string product, int quantity)
    {
        double price = 0;

        switch (product)
        {
            case "coffee":  price = quantity * coffeePrice; break;
            case "water":   price = quantity * waterPrice;  break;
            case "coke":    price = quantity * cokePrice;   break;
            case "snacks": price = quantity * snacksPrice; break;
        }

        Console.WriteLine($"{price:f2}");
    } 
}