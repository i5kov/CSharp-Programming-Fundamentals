using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string student = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            if (!students.ContainsKey(student))
            {
                students.Add(student, new List<double>());
            }
            students[student].Add(grade);
        }

        students = students.OrderByDescending(x => x.Value.Average()).ToDictionary(x => x.Key, x => x.Value);

        foreach (var item in students)
        {
            if (item.Value.Average() >= 4.5)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}