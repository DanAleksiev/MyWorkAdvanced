namespace _6.Jagged_ArrayModification
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArrey = new int[rows][];

            for (int row = 0; row < rows; row++)
                {
                int[] rowInfo = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                jaggedArrey[row] = new int[rowInfo.Length];
                for (int col = 0; col < rowInfo.Length; col++)
                    {
                    jaggedArrey[row][col] = rowInfo[col];
                    }
                }
            string command;
            while ((command = Console.ReadLine()) != "END")
                {
                string[] splitCommand = command.Split();
                int row = int.Parse(splitCommand[1]);
                int col = int.Parse(splitCommand[2]);
                int value = int.Parse(splitCommand[3]);

                // varify the indexses
                if (row<0 || row >= jaggedArrey.Length || col<0 || col >= jaggedArrey[row].Length)
                    {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                    }

                if (splitCommand[0] == "Add")
                    {
                    jaggedArrey[row][col] += value;
                    }
                else if (splitCommand[0] == "Subtract")
                    {
                    jaggedArrey[row][col] -= value;
                    }
                }

            //print out a jagged Array
            for (int row = 0; row < jaggedArrey.Length; row++)
                {
                for (int col = 0; col < jaggedArrey[row].Length; col++)
                    {
                    Console.Write(jaggedArrey[row][col] + " ");
                    }
                Console.WriteLine();
                }
            }
        }
    }