namespace _05.FashionBoutique
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Stack<int> queue = new(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                );

            int capacity = int.Parse(Console.ReadLine());
            int countHangers = 1;
            int countItems = 0;
            while (queue.Any())
                {
                if (countItems + queue.Peek() <= capacity)
                    {
                    countItems += queue.Pop();
                    }
                else
                    {
                    countHangers++;
                    countItems = 0;
                    }
                }
            Console.WriteLine(countHangers);
            }
        }
    }