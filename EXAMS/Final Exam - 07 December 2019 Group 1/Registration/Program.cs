using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Regex regex = new Regex(@"U\$([A-Z][a-z]{2,})U\$P@\$([A-z0-9]{5,}[0-9])P@\$");

        int count = 0;
        for (int i = 0; i < n; i++)
        {
            string login = Console.ReadLine();
            Match match = regex.Match(login);

            if (match.Success)
            {
                Console.WriteLine("Registration was successful");
                Console.WriteLine($"Username: {match.Groups[1]}, Password: {match.Groups[2]}");
                count++;
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }
        }
        Console.WriteLine($"Successful registrations: {count}");
    }
}