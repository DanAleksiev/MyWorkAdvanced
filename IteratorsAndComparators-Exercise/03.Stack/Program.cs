using System.Collections.Generic;

namespace _03.Stack
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<string> firstInput = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string action = firstInput[0];
            firstInput.RemoveAt(0);

            CustomStack<string> stack = new CustomStack<string>(firstInput);
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
                {
                List<string> output = input.Split().ToList();
                if (output[0] == "Pop")
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
                    stack.Push(output[1]);
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