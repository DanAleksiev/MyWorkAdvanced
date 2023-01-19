using System;
using System.Collections.Generic;

namespace _01.CountSameValuesInArray
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string[] input = Console.ReadLine().Split(" ");
            Dictionary<string,int> count = new Dictionary<string,int>();
            for (int i = 0; i < input.Length; i++)
                {
                if (!count.ContainsKey(input[i]))
                    {
                    count[input[i]] = 1;
                    }
                else
                    {
                    count[input[i]]++;
                    }
                }

            foreach (var numbers in count)
                {
                Console.WriteLine($"{numbers.Key} - {numbers.Value} times");
                }
            }
        }
    }
