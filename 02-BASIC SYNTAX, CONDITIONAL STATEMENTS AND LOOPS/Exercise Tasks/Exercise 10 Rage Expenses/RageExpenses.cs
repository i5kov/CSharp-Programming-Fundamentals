using System;


class RageExpenses
{
    static void Main()
    {
        int lostGames = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        double trashedHeadset = (lostGames / 2) * headsetPrice;
        double trashedMouse = (lostGames / 3) * mousePrice;
        double trashedKeyboard = (lostGames / 6) * keyboardPrice;
        double trashedDisplay = (lostGames / 12) * displayPrice;

        double rangeExpenses = trashedHeadset + trashedMouse + trashedKeyboard + trashedDisplay;

        Console.WriteLine($"Rage expenses: {rangeExpenses:f2} lv.");
    }
}