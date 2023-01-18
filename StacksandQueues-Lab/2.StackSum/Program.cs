using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<int> inputSplit = Console.ReadLine().Split().Select(int.Parse).ToList();
            var n = new Stack<int>(inputSplit);
           
            var split = new List<string>();
            string input;
            while ((input = Console.ReadLine().ToLower()) != "end")
                {
                split = input.Split().ToList();
                if ( split[0]== "add")
                    {
                    for (int i = 1; i <= 2; i++)
                        {
                        n.Push(int.Parse(split[i]));
                        }
                    }
                else if (split[0] == "remove")
                    {
                    int targets = int.Parse(split[1]);
                    if (n.Count > targets)
                        {
                        for (int i = 0; i < targets; i++)
                            {
                            n.Pop();
                            }
                        }
                    }
                }
            Console.WriteLine($"Sum: {n.Sum()}");
            }
        }
    }
