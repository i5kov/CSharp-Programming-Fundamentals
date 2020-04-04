using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    class Song
    {

        public Song(string type, string name, string time)
        {
            TypeList = type;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }


    static void Main()
    {
        int numberOfSongs = int.Parse(Console.ReadLine());

        List<Song> allSongs = new List<Song>();

        for (int i = 0; i < numberOfSongs; i++)
        {
            string[] inputSong = Console.ReadLine().Split('_');
            string type = inputSong[0];
            string name = inputSong[1];
            string time = inputSong[2];

            allSongs.Add(new Song(type, name, time));
        }

        string typeOfList = Console.ReadLine();

        if (typeOfList == "all")
        {
            allSongs
                .ToList()
                .ForEach(x => Console.WriteLine(x.Name));
        }
        else
        {
            allSongs
            .Where(x => x.TypeList == typeOfList)
            .ToList()
            .ForEach(x => Console.WriteLine(x.Name));
        }
    }
}