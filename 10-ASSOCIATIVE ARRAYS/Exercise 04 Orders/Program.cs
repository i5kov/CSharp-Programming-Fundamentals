using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, double> prices = new Dictionary<string, double>();
        Dictionary<string, int> quantities = new Dictionary<string, int>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "buy")
            {
                break;
            }
            string[] splitInput = input.Split();
            string product = splitInput[0];
            double price = double.Parse(splitInput[1]);
            int quantity = int.Parse(splitInput[2]);

            if (!quantities.ContainsKey(product))
            {
                quantities.Add(product, quantity);
                prices.Add(product, quantity * price);
            }
            else
            {
                quantities[product] += quantity;
                prices[product] = quantities[product] * price;
            }
        }


        foreach (var item in prices)
        {
            Console.WriteLine($"{item.Key} -> {item.Value:f2}");
        }
    }
}