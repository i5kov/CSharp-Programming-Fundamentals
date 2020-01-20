using System;


namespace Exercise_07_Vending_Machine
{
    class VendingMachine
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();

            double totalMoney = 0;
            while (input != "start")
            {
                double coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    totalMoney += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine().ToLower();
            }

            string product = Console.ReadLine().ToLower();
            double price = 0;
            bool isValidProduct = true;

            while (product != "end")
            {
                switch (product)
                {
                    case "nuts": price = 2.0; break;
                    case "water": price = 0.7; break;
                    case "crisps": price = 1.5; break;
                    case "soda": price = 0.8; break;
                    case "coke": price = 1.0; break;
                    default:
                        Console.WriteLine("Invalid product");
                        isValidProduct = false;
                        break;
                }

                if (isValidProduct)
                {
                    if (totalMoney >= price)
                    {
                        Console.WriteLine($"Purchased {product}");
                        totalMoney -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                product = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}