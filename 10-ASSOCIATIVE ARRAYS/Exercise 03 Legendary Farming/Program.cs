using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
        Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

        keyMaterials.Add("shards", 0);
        keyMaterials.Add("fragments", 0);
        keyMaterials.Add("motes", 0);

        bool stop = false;

        while (true)
        {
            string[] materials = Console.ReadLine().ToLower().Split();

            for (int i = 0; i < materials.Length; i += 2)
            {
                string currentMaterial = materials[i + 1];
                int quantity = int.Parse(materials[i]);

                if (currentMaterial == "shards" || currentMaterial == "fragments" || currentMaterial == "motes")
                {
                    keyMaterials[currentMaterial] += quantity;
                    if (keyMaterials[currentMaterial] >= 250)
                    {
                        Console.WriteLine($"{getObtainedMaterial(currentMaterial)} obtained!");
                        keyMaterials[currentMaterial] -= 250;
                        stop = true;
                        break;
                    }
                }
                else
                {
                    if (!junkMaterials.ContainsKey(currentMaterial))
                    {
                        junkMaterials.Add(currentMaterial, quantity);
                    }
                    else
                    {
                        junkMaterials[currentMaterial] += quantity;
                    }
                }
            }
            if (stop)
            {
                break;
            }
        }

        keyMaterials = keyMaterials
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        junkMaterials = junkMaterials
            .OrderBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        printMaterials(keyMaterials);
        printMaterials(junkMaterials);
    }

    static string getObtainedMaterial(string material)
    {
        string obtainedMaterial = " ";
        switch (material)
        {
            case "shards": obtainedMaterial = "Shadowmourne"; break;
            case "fragments": obtainedMaterial = "Valanyr"; break;
            case "motes": obtainedMaterial = "Dragonwrath"; break;
        }
        return obtainedMaterial;
    }

    static void printMaterials(Dictionary<string, int> dict)
    {
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}