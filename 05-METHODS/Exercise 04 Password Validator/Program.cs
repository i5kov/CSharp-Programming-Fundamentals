using System;

class Program
{
    static void Main()
    {
        string password = Console.ReadLine();

        if (IsValidLength(password) && IsHasAtleast2Digit(password) && IsHasAtleast2Digit(password))
        {
            Console.WriteLine("Password is valid");
        }

        if (!IsValidLength(password))
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
        }
        if (!IsHasOnlyLettersAndDigit(password))
        {
            Console.WriteLine("Password must consist only of letters and digits");
        }
        if (!IsHasAtleast2Digit(password))
        {
            Console.WriteLine("Password must have at least 2 digits");
        }

    }

    private static bool IsValidLength(string password)
    {
        return password.Length >= 6 && password.Length <= 10;
    }

    private static bool IsHasAtleast2Digit(string password)
    {
        int digit = 0;
        for (int i = 0; i < password.Length; i++)
        {
            if (Char.IsDigit(password[i]))
            {
                digit++;
            }
        }

        return digit >= 2;
    }

    private static bool IsHasOnlyLettersAndDigit(string password)
    {
        for (int i = 0; i < password.Length; i++)
        {
            if (!Char.IsLetterOrDigit(password[i]))
            {
                return false;
            }
        }
        return true;
    }
}