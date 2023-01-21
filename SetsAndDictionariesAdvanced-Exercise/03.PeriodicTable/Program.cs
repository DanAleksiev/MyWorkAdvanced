using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int loops = int.Parse(Console.ReadLine());

            SortedSet<string> chemicals = new SortedSet<string>();
            for (int i = 0; i < loops; i++)
                {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int numOfElementsInInput = 0; numOfElementsInInput < input.Length; numOfElementsInInput++)
                    {
                    chemicals.Add(input[numOfElementsInInput]);
                    }
                }

            foreach (var chemical in chemicals)
                {
                Console.Write(chemical + " ");
                }
            }
        }
    }
