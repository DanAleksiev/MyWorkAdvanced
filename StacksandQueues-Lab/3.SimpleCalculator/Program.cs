using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SimpleCalculator
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            var n = new Stack<string>();
            List<string> numbers = input.Split().ToList();
            for (int i = numbers.Count-1; i >= 0; i--)
                {
                n.Push(numbers[i]);
                }
            while (n.Count > 1)
                {
                int firtnum = int.Parse(n.Pop());
                string operation = n.Pop();
                int secondNum = int.Parse(n.Pop());

                if (operation == "+")
                    {
                    int sum = firtnum + secondNum;
                    n.Push(sum.ToString());
                    }
                else if (operation == "-")
                    {
                    int sum = firtnum - secondNum;
                    n.Push(sum.ToString());
                    }
                }
            Console.WriteLine(n.Peek());
            }
        }
    }
