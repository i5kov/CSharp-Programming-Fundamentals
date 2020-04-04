using System;


class Login
{
    static void Main()
    {
        string username = Console.ReadLine();
        string password = Console.ReadLine();

        string realPassword = "";
        for (int i = username.Length - 1; i >= 0; i--)
        {
            realPassword += username[i];
        }

        int tries = 1;
        while(true)
        {
            if (realPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
                break;
            }
            else
            {
                if (tries > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
                tries++;
            }
        }
    }
}