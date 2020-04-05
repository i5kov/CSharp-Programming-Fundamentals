using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {

            int employeeOne = int.Parse(Console.ReadLine());
            int employeeTwo = int.Parse(Console.ReadLine());
            int employeeThree = int.Parse(Console.ReadLine());
            int total = employeeOne + employeeTwo + employeeThree;
            int people = int.Parse(Console.ReadLine());
            int peopleLeft = people;

            int hours = 0;

            for (int i = 1; i < people; i++)
            {
                if (peopleLeft <= 0)
                {
                    break;
                }

                if (i % 4 == 0)
                {
                }
                else
                {
                    peopleLeft -= total;
                }

                hours++;
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
