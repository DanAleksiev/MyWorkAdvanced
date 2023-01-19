using System;
using System.Collections.Generic;

namespace _05.CitiesByContinentAndCountry
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int turns = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> politicalPowers = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < turns; i++)
                {
                string input = Console.ReadLine();
                string[] split = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = split[0];
                string country = split[1];
                string city = split[2];

                if (!politicalPowers.ContainsKey(continent))
                    {
                    politicalPowers.Add(continent, new Dictionary<string, List<string>>());
                    }
                if (!politicalPowers[continent].ContainsKey(country))
                    {
                    politicalPowers[continent].Add(country, new List<string>());
                    }

                politicalPowers[continent][country].Add(city);
                }

            foreach (var continent in politicalPowers)
                {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                    {
                    Console.WriteLine($"    {country.Key} -> {string.Join(", ", country.Value)}");
                    }
                }
            }
        }
    }
