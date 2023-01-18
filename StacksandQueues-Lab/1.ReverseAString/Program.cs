using System;
using System.Collections.Generic;

namespace _1.ReverseAString
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            Stack<char> inputReverse = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
                {
                inputReverse.Push(input[i]);
                }
            while (inputReverse.Count != 0)
                {
                Console.Write(inputReverse.Pop());
                }
            }
        }
    }
