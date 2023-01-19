using System;
using System.Collections.Generic;

namespace _06.RecordUniqueNames
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            HashSet<string> set = new HashSet<string>();
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
                {
                string name = Console.ReadLine();
                set.Add(name);
                }

            foreach (var person in set)
                {
                Console.WriteLine(person);
                }
            }
        }
    }
