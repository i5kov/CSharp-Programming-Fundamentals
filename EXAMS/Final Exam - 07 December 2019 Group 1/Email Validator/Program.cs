using Microsoft.VisualBasic;
using System;

class Program
{
    static void Main(string[] args)
    {
        string email = Console.ReadLine();
        string command = Console.ReadLine();

        while (command != "Complete")
        {
            string[] split = command.Split();
            if (command.Contains("Make Upper"))
            {
                email = email.ToUpper();
                Console.WriteLine(email);
            }
            if (command.Contains("Make Lower"))
            {
                email = email.ToLower();
                Console.WriteLine(email);
            }
            if (command.Contains("GetDomain"))
            {
                string domain = email.Substring(email.Length - int.Parse(split[1]));
                Console.WriteLine(domain);

            }
            if (command.Contains("GetUsername"))
            {
                if (!email.Contains("@"))
                {
                    Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                } 
                else
                {
                    int index = email.IndexOf("@");
                    string username = email.Substring(0, index);
                    Console.WriteLine(username);
                }
            }
            if (command.Contains("Replace"))
            {
                email = email.Replace(split[1], "-");
                Console.WriteLine(email);
            }
            if (command.Contains("Encrypt"))
            {
                for (int i = 0; i < email.Length; i++)
                {
                    Console.Write($"{(int)email[i]} ");
                }
                Console.WriteLine();
            }

            command = Console.ReadLine();
        }
    }
}