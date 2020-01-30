using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        while (input != "END")
        {
            int number = int.Parse(input);
            if (IsPalindrome(number))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            input = Console.ReadLine();
        }
    }

    private static bool IsPalindrome(int number)
    {
        int sum = 0;
        int condition = number;
        while (condition > 0)
        {
            int digit = condition % 10;
            sum = (sum * 10) + digit;
            condition /= 10;
        }

        return sum == number;

    }
}