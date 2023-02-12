using System.Collections.Generic;

namespace _03.Stack
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            CustomStack<string> stack = new CustomStack<string>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
                {

                string[] afterInput =input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string action = afterInput[0];
                if (action == "Pop")
                    {
                    try
                        {
                        stack.Pop();
                        }
                    catch (Exception exception)
                        {
                        Console.WriteLine(exception.Message);
                        }
                    }
                else
                    {
                    foreach (string item in afterInput.Skip(1))
                        {
                        stack.Push(item);
                        }
                    }
                }

            foreach (var item in stack)
                {
                Console.WriteLine(item);
                }
            foreach (var item in stack)
                {
                Console.WriteLine(item);
                }
            }
        }
    }