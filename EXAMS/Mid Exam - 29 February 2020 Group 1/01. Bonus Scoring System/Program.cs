using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double totalBonus = 0;
            double maxBonus = 0;
            int studentAttended = 0;

            for (int i = 0; i < countOfStudents; i++)
            {
                int attendance = int.Parse(Console.ReadLine());
                totalBonus = (attendance * 1.0 / countOfLectures * 1.0) * (5 + additionalBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    studentAttended = attendance;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {studentAttended} lectures.");
        }
    }
}
