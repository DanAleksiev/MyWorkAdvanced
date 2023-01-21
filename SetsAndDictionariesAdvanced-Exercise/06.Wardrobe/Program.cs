using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int numOfClothes = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numOfClothes; i++)
                {
                string[] clothRack = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string colour = clothRack[0];
                string[] clothes = clothRack[1].Split(",");

                if (!wardrobe.ContainsKey(colour))
                    {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                    }

                for (int y = 0; y < clothes.Length; y++)
                    {
                    string currentCloth = clothes[y];

                    if (!wardrobe[colour].ContainsKey(currentCloth))
                        {
                        wardrobe[colour].Add(currentCloth, 0);
                        }
                    wardrobe[colour][clothes[y]]++;
                    }
                }

            string[] target = Console.ReadLine().Split();
            string colourTarget = target[0];
            string clothTarget = target[1];

            foreach (var colour in wardrobe)
                {
                Console.WriteLine(colour.Key + " clothes:");
                foreach (var cloth in colour.Value)
                    {
                    if (colour.Key == colourTarget && cloth.Key == clothTarget)
                        {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                        }
                    else
                        {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                        }
                    }
                }
            }
        }
    }
