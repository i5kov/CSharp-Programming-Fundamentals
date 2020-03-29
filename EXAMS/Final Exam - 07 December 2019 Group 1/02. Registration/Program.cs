using System;
using System.Text.RegularExpressions;

namespace _02._Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"U\$([A-Z][a-z]{2,})U\$P@\$([A-z]{5,}[0-9]+)P@\$");
            int n = int.Parse(Console.ReadLine());
            int successfulRegistrationsCount = 0;

            for (int i = 0; i < n; i++)
            {
                string credentials = Console.ReadLine();
                Match match = regex.Match(credentials);

                if (match.Success)
                {
                    string username = match.Groups[1].Value;
                    string password = match.Groups[2].Value;
                    successfulRegistrationsCount++;

                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {username}, Password: {password}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {successfulRegistrationsCount}");
        }
    }
}