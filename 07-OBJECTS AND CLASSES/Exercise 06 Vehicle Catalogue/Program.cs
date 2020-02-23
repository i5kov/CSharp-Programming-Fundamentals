using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<Vehicle> vehicles = new List<Vehicle>();

        while (input != "End")
        {
            string[] vehicle = input.Split();
            string typeOfVehicle = vehicle[0];
            string model = vehicle[1];
            string color = vehicle[2];
            int horsePower = int.Parse(vehicle[3]);

            vehicles.Add(new Vehicle(typeOfVehicle, model, color, horsePower));

            input = Console.ReadLine();
        }

        string inputModel = Console.ReadLine();

        while (inputModel != "Close the Catalogue")
        {

            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Model.Contains(inputModel))
                {
                    Console.WriteLine($"Type: {FirstLetterUpperCase(vehicles[i].Type)}");
                    Console.WriteLine($"Model: {vehicles[i].Model}");
                    Console.WriteLine($"Color: {vehicles[i].Color}");
                    Console.WriteLine($"Horsepower: {vehicles[i].HorsePower}");
                }
            }

            inputModel = Console.ReadLine();
        }

        int carCount = 0;
        int carHorsePower = 0;
        int truckCount = 0;
        int truckHorsePower = 0;

        foreach (Vehicle currentVehicle in vehicles)
        {
            if (currentVehicle.Type == "car")
            {
                carCount++;
                carHorsePower += currentVehicle.HorsePower;
            }
            else if (currentVehicle.Type == "truck")
            {
                truckCount++;
                truckHorsePower += currentVehicle.HorsePower;
            }
        }

        double averageCarHorsePower = carHorsePower / (carCount * 1.0);
        double averageTruckHorsePower = truckHorsePower / (truckCount * 1.0);

        if (carCount > 0)
        {
            Console.WriteLine($"Cars have average horsepower of: {averageCarHorsePower:f2}.");
        }
        else
        {
            Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
        }
        if (truckCount > 0)
        {
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsePower:f2}.");
        }
        else
        {
            Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
        }
    }
    
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }

    static string FirstLetterUpperCase(String s)
    {
        return char.ToUpper(s[0]) + s.Substring(1);
    }
}