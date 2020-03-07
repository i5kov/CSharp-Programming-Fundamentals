using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
        List<string> students = new List<string>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }
            string[] splitInput = input.Split(" : ");
            string courseName = splitInput[0];
            string studentName = splitInput[1];

            if (!courses.ContainsKey(courseName))
            {
                courses.Add(courseName, students);
                students.Add(studentName);
                students = new List<string>();
            }
            else
            {
                courses[courseName].Add(studentName);
            }
        }

        foreach (var course in courses.OrderByDescending(x => x.Value.Count))
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");
            
            foreach (var name in course.Value.OrderBy(n => n))
            {
                Console.WriteLine($"-- {name}");
            }
        }
    }
}