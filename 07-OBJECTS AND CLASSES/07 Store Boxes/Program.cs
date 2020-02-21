using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        List<Box> boxes = new List<Box>();

        while (input != "end")
        {
            string[] inputItem = input.Split();
            int serialNumber = int.Parse(inputItem[0]);
            string itemName = inputItem[1];
            int itemQuantity = int.Parse(inputItem[2]);
            double itemPrice = double.Parse(inputItem[3]);
            double boxPrice = itemQuantity * itemPrice;

            boxes.Add(new Box(serialNumber, itemName, itemPrice, itemQuantity, boxPrice));
            input = Console.ReadLine();
        }

        boxes
            .OrderByDescending(x => x.BoxPrice)
            .ToList()
            .ForEach(x =>
            {

                Console.WriteLine($"{ x.SerialNumber}");
                Console.WriteLine($"-- {x.Item.Name} - ${x.Item.Price:f2}: {x.Quantity}");
                Console.WriteLine($"-- ${x.BoxPrice:f2}");
            });
    }

    class Item
    {
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Box(int serialNumber, string itemName, double itemPrice, int itemQuantity, double boxPrice)
        {
            SerialNumber = serialNumber;
            Item = new Item(itemName, itemPrice);
            Quantity = itemQuantity;
            BoxPrice = boxPrice;
        }

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double BoxPrice { get; set; }
    }
}