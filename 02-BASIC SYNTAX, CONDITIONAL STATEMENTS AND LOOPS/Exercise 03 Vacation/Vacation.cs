using System;


class Vacation
{
    static void Main()
    {
        int groupOfPeople = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine().ToLower();
        string dayOfWeek = Console.ReadLine().ToLower();

        double price = 0.0;

        switch (groupType)
        {
            case "students":
                if (dayOfWeek.Equals("friday"))
                {
                    price = 8.45 * groupOfPeople;
                }
                else if (dayOfWeek.Equals("saturday"))
                {
                    price = 9.80 * groupOfPeople;
                }
                else if (dayOfWeek.Equals("sunday"))
                {
                    price = 10.46 * groupOfPeople;
                }

                if (groupOfPeople >= 30)
                {
                    price -= (price * 0.15);
                }
                break;

            case "business":
                if (groupOfPeople >= 100)
                {
                    groupOfPeople -= 10;
                }

                if (dayOfWeek.Equals("friday"))
                {
                    price = 10.90 * groupOfPeople;
                }
                else if (dayOfWeek.Equals("saturday"))
                {
                    price = 15.60 * groupOfPeople;
                }
                else if (dayOfWeek.Equals("sunday"))
                {
                    price = 16 * groupOfPeople;
                }
                break;

            case "regular":
                if (dayOfWeek.Equals("friday"))
                {
                    price = 15 * groupOfPeople;
                }
                else if (dayOfWeek.Equals("saturday"))
                {
                    price = 20 * groupOfPeople;
                }
                else if (dayOfWeek.Equals("sunday"))
                {
                    price = 22.50 * groupOfPeople;
                }

                if (groupOfPeople >= 10 && groupOfPeople <= 20)
                {
                    price -= (price * 0.05);
                }
                break;
        }

        Console.WriteLine($"Total price: {price:f2}");
    }
}