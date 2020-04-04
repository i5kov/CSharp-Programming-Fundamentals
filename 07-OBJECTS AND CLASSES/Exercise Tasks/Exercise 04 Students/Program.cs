using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int countOfStudents = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();

        for (int i = 0; i < countOfStudents; i++)
        {
            string[] studentInfo = Console.ReadLine().Split();
            string studentFirstName = studentInfo[0];
            string studentLastName = studentInfo[1];
            double studentGrade = double.Parse(studentInfo[2]);

            students.Add(new Student(studentFirstName, studentLastName, studentGrade));
        }

        students
            .OrderByDescending(x => x.Grade)
            .ToList()
            .ForEach(x =>
            {
                Console.WriteLine($"{x.FirstName} {x.LastName}: {x.Grade:f2}");
            });
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}