using System;

namespace _01._Email_Validator
{
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
                else if (command.Contains("Make Lower"))
                {
                    email = email.ToLower();
                    Console.WriteLine(email);
                }
                else if (command.Contains("GetDomain"))
                {
                    int count = int.Parse(split[1]);
                    string domain = email.Substring(email.Length - count);
                    Console.WriteLine(domain);
                }
                else if (command.Contains("GetUsername"))
                {
                    if (email.Contains("@"))
                    {
                        int index = email.IndexOf("@");
                        string username = email.Substring(0, index);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                    
                }
                else if (command.Contains("Replace"))
                {
                    char c = char.Parse(split[1]);
                    email = email.Replace(c, '-');
                    Console.WriteLine(email);
                }
                else if (command.Contains("Encrypt"))
                {
                    foreach (var letter in email)
                    {
                        Console.Write($"{(int)letter} ");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
