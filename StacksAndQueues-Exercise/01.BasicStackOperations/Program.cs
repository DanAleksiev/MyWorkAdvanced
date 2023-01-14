namespace _01.BasicStackOperations
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numberPool = new Stack<int>();

            int numbersToPush = dimentions[0];
            int numbersToPop = dimentions[1];
            int targetNum = dimentions[2];

            for (int i = 0; i < numbersToPush; i++)
                {
                numberPool.Push(numbers[i]);
                }
            for (int i = 0; i < numbersToPop; i++)
                {
                numberPool.Pop();
                }

            if (numberPool.Contains(targetNum))
                {
                Console.WriteLine("true");
                }
            else
                {
                if (numberPool.Count == 0)
                    {
                    Console.WriteLine("0");
                    }
                else
                    {
                    int smallest = int.MaxValue;
                    for (int i = 0; i < numberPool.Count; i++)
                        {
                        if (smallest > numberPool.Peek())
                            {
                            smallest = numberPool.Pop();
                            i--;
                            }
                        else
                            {
                            numberPool.Pop();
                            i--;
                            }
                        }
                    Console.WriteLine(smallest);
                    }
                }
            }
        }
    }