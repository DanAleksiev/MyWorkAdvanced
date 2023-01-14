namespace _02.BasicQueueOperations
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numberPool = new Queue<int>();

            int numbersToEnQ = dimentions[0];
            int numbersToDeQ = dimentions[1];
            int targetNum = dimentions[2];

            for (int i = 0; i < numbersToEnQ; i++)
                {
                numberPool.Enqueue(numbers[i]);
                }
            for (int i = 0; i < numbersToDeQ; i++)
                {
                numberPool.Dequeue();
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
                            smallest = numberPool.Dequeue();
                            i--;
                            }
                        else
                            {
                            numberPool.Dequeue();
                            i--;
                            }
                        }
                    Console.WriteLine(smallest);
                    }
                }
            }
        }
    }