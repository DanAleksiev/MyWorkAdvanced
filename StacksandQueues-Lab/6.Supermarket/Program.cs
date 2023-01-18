using System;
using System.Collections.Generic;

namespace _6.Supermarket
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input;
            Queue<string> people = new Queue<string>();
            while ((input = Console.ReadLine()) != "End")
                {
                if (input == "Paid")
                    {
                    int count = people.Count;
                    for (int i = 0; i < count; i++)
                        {
                        Console.WriteLine(people.Dequeue());
                        }
                    }
                else
                    {
                    people.Enqueue(input);
                    }
                }
            Console.WriteLine($"{people.Count} people remaining.");
            }
        }
    }
