namespace _04.FastFood
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int foodInStock = int.Parse(Console.ReadLine());
            Queue<int> line = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Console.WriteLine(line.Max());

            for (int i = 0; i < line.Count; i++)
                {
                if (foodInStock >= line.Peek())
                    {
                    foodInStock -= line.Dequeue();
                    i--;
                    }
                else
                    {
                    break;
                    }
                }
            if (line.Count != 0)
                {
                Console.Write("Orders left: ");
                Console.Write(string.Join(" ", line));
                }
            else
                {
                Console.WriteLine("Orders complete");
                }
            }
        }
    }