using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] setSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int lenghtSet1 = setSize[0];
            int lenghtSet2 = setSize[1];

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < lenghtSet1 + lenghtSet2; i++)
                {

                if (i < lenghtSet1)
                    {
                    set1.Add(int.Parse(Console.ReadLine()));
                    }
                else
                    {
                    set2.Add(int.Parse(Console.ReadLine()));
                    }
                }

            if (set1.Count > set2.Count)
                {
                foreach (var number in set2)
                    {
                    if (set1.Contains(number))
                        {
                        Console.Write(number + " ");
                        }
                    }
                }
            else
                {
                foreach (var number in set1)
                    {
                    if (set2.Contains(number))
                        {
                        Console.Write(number + " ");
                        }
                    }
                }

            }
        }
    }
