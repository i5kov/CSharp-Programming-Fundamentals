using System;


class Program
{
    static void Main(string[] args)
    {
        string password = Console.ReadLine();
        bool passwordLenght = PasswordLenght(password);
        bool passwordLetterAndDigits = PasswordLetterAndDigits(password);
        bool passwordDigitCounter = PasswordDigitCounter(password);

        if (passwordLenght && passwordLetterAndDigits && passwordDigitCounter)
        {
            Console.WriteLine("Password is valid");
        }

        if (!passwordLenght)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
        }
        if (!passwordLetterAndDigits)
        {
            Console.WriteLine("Password must consist only of letters and digits");
        }
        if (!passwordDigitCounter)
        {
            Console.WriteLine("Password must have at least 2 digits");
        }
    }

    private static bool PasswordLenght(string password)
    {
        return password.Length >= 6 && password.Length <= 10;
    }

    private static bool PasswordDigitCounter(string password)
    {
        int counter = 0;
        for (int i = 0; i < password.Length; i++)
        {
            if (char.IsDigit(password[i]))
            {
                counter++;
            }
        }

        return counter >= 2;
    }

    private static bool PasswordLetterAndDigits(string password)
    {
        bool IsLetterAndDigitOnly = true;
        for (int i = 0; i < password.Length; i++)
        {
            if (!(char.IsLetterOrDigit(password[i])))
            {
                IsLetterAndDigitOnly = false;
            }
        }
        return IsLetterAndDigitOnly;
    }
}