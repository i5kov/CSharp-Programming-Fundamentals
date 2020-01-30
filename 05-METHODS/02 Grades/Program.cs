using System;

class Program
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());
        Console.WriteLine(getGrade(grade));
    }

    static string getGrade(double grade)
    {
        string result = string.Empty;
        if (grade >= 2.00 && grade < 3)
        {
            result = "Fail";
        }
        else if (grade >= 3.00 && grade < 3.50)
        {
            result = "Poor";
        }
        else if (grade >= 3.50 && grade < 4.50)
        {
            result = "Good";
        }
        else if (grade >= 4.50 && grade < 5.50)
        {
            result = "Very good";
        }
        else if (grade >= 5.50 && grade <= 6.00)
        {
            result = "Excellent";
        }

        return result;
    }
}