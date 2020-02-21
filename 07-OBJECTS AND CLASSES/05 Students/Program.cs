using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Student
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] studentInformation = command.Split();
                string firstName = studentInformation[0];
                string lastName = studentInformation[1];
                int age = int.Parse(studentInformation[2]);
                string homeTown = studentInformation[3];

                students.Add(new Student(firstName, lastName, age, homeTown));
                command = Console.ReadLine();
            }

            string city = Console.ReadLine();

            students
                .Where(x => x.HomeTown == city)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} is {x.Age} years old."));
        }

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}