using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.PrintEvenNumbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue <int> n = new Queue <int>();

            for (int i = 0; i < input.Length; i++)
                {
                if (input[i] % 2 == 0)
                    {
                    n.Enqueue(input[i]);
                    }
                }

            Console.WriteLine(string.Join(", ", n));
            }
        }
    }
