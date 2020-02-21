using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        VehicleCatalogue vehicleCatalogue = new VehicleCatalogue();

        while (input != "end")
        {
            string[] vehicle = input.Split("/");
            string type = vehicle[0];
            string brand = vehicle[1];
            string model = vehicle[2];

            if (type == "Car")
            {
                int horsePower = int.Parse(vehicle[3]);
                vehicleCatalogue.Cars.Add(new Car(brand, model, horsePower));
            }
            else
            {
                int weight = int.Parse(vehicle[3]);
                vehicleCatalogue.Trucks.Add(new Truck(brand, model, weight));
            }

            input = Console.ReadLine();
        }
        
        Console.WriteLine("Cars:");
        vehicleCatalogue.Cars
            .OrderBy(x => x.Brand)
            .ToList()
            .ForEach(x => Console.WriteLine($"{x.Brand}: {x.Model} - {x.HorsePower}hp"));

        Console.WriteLine("Trucks:");
        vehicleCatalogue.Trucks
            .OrderBy(x => x.Brand)
            .ToList()
            .ForEach(x => Console.WriteLine($"{x.Brand}: {x.Model} - {x.Weight}kg"));
    }

    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class VehicleCatalogue
    {
        public VehicleCatalogue()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }

        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}