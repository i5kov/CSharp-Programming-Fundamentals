using System;


class PadawanEquipment
{
    static void Main()
    {
        double moneyAmount = double.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        double lightsabersPrice = double.Parse(Console.ReadLine());
        double robesPrice = double.Parse(Console.ReadLine());
        double beltsPrice = double.Parse(Console.ReadLine());

        int freeBelts = students / 6;

        double neededEquipment = lightsabersPrice * Math.Ceiling(students + (students * 0.10)) + robesPrice * (students)
            + beltsPrice * (students - freeBelts);

        if (moneyAmount >= neededEquipment)
        {
            Console.WriteLine($"The money is enough - it would cost {neededEquipment:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivan Cho will need {(neededEquipment - moneyAmount):f2}lv more.");
        }
    }
}