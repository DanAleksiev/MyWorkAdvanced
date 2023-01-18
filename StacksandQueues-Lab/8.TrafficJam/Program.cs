using System;
using System.Collections.Generic;

namespace _8.TrafficJam
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int greenCarsToPass = int.Parse(Console.ReadLine());
            string input;
            int count = 0;
            var cars = new Queue<string>();
            while ((input = Console.ReadLine()) != "end")
                {
                if (input == "green")
                    {
                    for (int i = 0; i < greenCarsToPass; i++)
                        {
                        if (cars.Count != 0)
                            {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            count++;
                            }
                        }
                    }
                else
                    {
                    cars.Enqueue(input);
                    }
                }
            Console.WriteLine($"{count} cars passed the crossroads.");
            }
        }
    }
