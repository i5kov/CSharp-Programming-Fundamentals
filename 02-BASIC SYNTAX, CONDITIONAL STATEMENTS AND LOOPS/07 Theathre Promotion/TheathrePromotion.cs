using System;


class TheathrePromotion
{
    static void Main()
    {
        string typeOfDay = Console.ReadLine().ToLower();
        int ageOfPerson = int.Parse(Console.ReadLine());

        int price = 0;

        switch (typeOfDay)
        {
            case "weekday":
                if ((ageOfPerson >= 0 && ageOfPerson <= 18) || (ageOfPerson > 64 && ageOfPerson <= 122))
                {
                    price = 12;
                }
                else if (ageOfPerson > 18 && ageOfPerson <= 64)
                {
                    price = 18;
                }
                break;

            case "weekend":
                if ((ageOfPerson >= 0 && ageOfPerson <= 18) || (ageOfPerson > 64 && ageOfPerson <= 122))
                {
                    price = 15;
                }
                else if (ageOfPerson > 18 && ageOfPerson <= 64)
                {
                    price = 20;
                }
                break;

            case "holiday":
                if (ageOfPerson >= 0 && ageOfPerson <= 18)
                {
                    price = 5;
                }
                else if (ageOfPerson > 18 && ageOfPerson <= 64)
                {
                    price = 12;
                }
                else if (ageOfPerson > 64 && ageOfPerson <= 122)
                {
                    price = 10;
                }
                break;
        }

        if (price <= 0)
        {
            Console.WriteLine("Error!");
        }
        else
        {
            Console.WriteLine($"{price}$");
        }
    }
}