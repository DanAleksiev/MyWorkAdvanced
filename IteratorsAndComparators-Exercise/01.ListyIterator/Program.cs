using ListyIterator;

namespace _01.ListyIterator
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<string> create = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();
            CustomListyIterator<string> list = new CustomListyIterator<string>(create);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
                {
                switch (input)
                    {
                    case "Move":
                    Console.WriteLine(list.Move());
                    break;
                    case "HasNext":
                    Console.WriteLine(list.HasNext());
                    break;
                    case "Print":
                    try
                        {
                        list.Print();
                        }
                    catch (Exception exception)
                        {
                        Console.WriteLine(exception.Message);
                        }
                    break;
                    }
                }
            }
        }
    }