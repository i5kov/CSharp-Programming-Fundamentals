using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<Person> people = new List<Person>();

        while (input != "End")
        {
            string[] personInfo = input.Split();
            string name = personInfo[0];
            string id = personInfo[1];
            int age = int.Parse(personInfo[2]);

            people.Add(new Person(name, id, age));
            input = Console.ReadLine();
        }

        people = people.OrderBy(x => x.Age).ToList();

        foreach (Person person in people)
        {
            Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}