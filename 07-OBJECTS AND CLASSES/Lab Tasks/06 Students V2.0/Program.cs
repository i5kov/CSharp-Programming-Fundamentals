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

                if (IsStudentAlreadyExist(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    students.Add(new Student(firstName, lastName, age, homeTown));
                }
                command = Console.ReadLine();
            }

            string city = Console.ReadLine();

            students
                .Where(x => x.HomeTown == city)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} is {x.Age} years old."));
        }

        static bool IsStudentAlreadyExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student currentStudent in students)
            {
                if (currentStudent.FirstName == firstName && currentStudent.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student currentStudent in students)
            {
                if (currentStudent.FirstName == firstName && currentStudent.LastName == lastName)
                {
                    existingStudent = currentStudent;
                }
            }

            return existingStudent;
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