namespace _07.TruckTour
    {
    internal class Program
        {
        static void Main(string[] args)
            {

            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < numberOfPumps; i++)
                {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(input);
                }

            int litePerKilometer = 1;
            int startIndex = 0;

            while (true)
                {
                bool isComplete = true;
                int totalLiters = 0;

                foreach (var pump in pumps)
                    {
                    int liters = pump[0];
                    int distance = pump[1];

                    totalLiters += liters;
                    if (totalLiters - distance * litePerKilometer < 0)
                        {
                        startIndex++;
                        int[] currentPump = pumps.Dequeue();
                        pumps.Enqueue(currentPump);

                        isComplete= false;

                        break;
                        }
                    totalLiters -= distance * litePerKilometer;
                    }
                if (isComplete)
                    {
                    Console.WriteLine(startIndex);
                    break;
                    }
                }
            }
        }
    }