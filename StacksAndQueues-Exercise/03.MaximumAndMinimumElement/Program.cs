namespace _03.MaximumAndMinimumElement
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int cikles = int.Parse(Console.ReadLine());
            Stack<int> enquarys = new Stack<int>();
            for (int i = 0; i < cikles; i++)
                {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int action = input[0];

                if (action == 1)
                    {
                    int addNumber = input[1];
                    enquarys.Push(addNumber);
                    }
                if (action == 2)
                    {
                    enquarys.Pop();
                    }
                if (action == 3)
                    {
                    if (enquarys.Count != 0)
                        {
                        int maxElement = enquarys.Max();
                        Console.WriteLine(maxElement);
                        }
                    }
                if (action == 4)
                    {
                    if (enquarys.Count != 0)
                        {
                        int minElement = enquarys.Min();
                        Console.WriteLine(minElement);
                        }
                    }
                }
            if (enquarys.Count != 0)
                {
                Console.WriteLine(string.Join(", ", enquarys));
                }
            }
        }
    }