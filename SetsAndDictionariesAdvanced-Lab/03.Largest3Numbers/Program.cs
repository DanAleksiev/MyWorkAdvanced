using System;
using System.Linq;
namespace _03.Largest3Numbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x=>x)
                .ToArray();

            for (int i = 0; i < 3; i++)
                {
                if (i < input.Length)
                    {
                    Console.Write(input[i] +" ");
                    }
                }
            }
        }
    }
