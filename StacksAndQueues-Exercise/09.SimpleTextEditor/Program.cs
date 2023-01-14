using System.ComponentModel.Design;

namespace _09.SimpleTextEditor
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int numberOfOperations = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> backup = new ();

            for (int i = 0; i < numberOfOperations; i++)
                {
                string[] request = Console.ReadLine().Split();
                string action = request[0];

                if (action == "1")
                    {
                    backup.Push(text);
                    text += request[1];
                    }
                else if (action == "2")
                    {
                    backup.Push(text);
                    int erase = int.Parse(request[1]);
                    text = text.Remove(text.Length - erase);  
                    }
                else if (action == "3")
                    {
                    int index = int.Parse(request[1])-1;
                    Console.WriteLine(text[index]);
                    }
                else if (action == "4")
                    {
                    text = backup.Pop();
                    }
                }
            }
        }
    }