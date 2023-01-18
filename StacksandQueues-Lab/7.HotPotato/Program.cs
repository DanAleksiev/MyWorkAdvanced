using System;
using System.Collections.Generic;

namespace _7.HotPotato
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string[] kids = Console.ReadLine().Split(' ');
            int turns = int.Parse(Console.ReadLine());
            Queue<string> game = new Queue<string>(kids);
            int toss = 1;
            while (game.Count != 1)
                {
                string child = game.Dequeue();

                if (toss < turns)
                    {
                    toss++;
                    game.Enqueue(child);
                    }
                else
                    {
                    Console.WriteLine($"Removed {child}");
                    toss = 1;
                    }

                }
            Console.WriteLine($"Last is {game.Dequeue()}");
            }
        }
    }
