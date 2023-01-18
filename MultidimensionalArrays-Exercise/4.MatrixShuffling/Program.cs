namespace _4.MatrixShuffling
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] ints = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            int rows = ints[0];
            int cols = ints[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
                {
                int[] indexes = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                    {
                    matrix[row, col] = indexes[col];
                    }
                }

            string input;
            while ((input = Console.ReadLine()) != "END")
                {
                string[] split = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (split[0] == "swap" && split.Length == 5)
                    {
                    int row1 = int.Parse(split[1]);
                    int col1 = int.Parse(split[2]);
                    int row2 = int.Parse(split[3]);
                    int col2 = int.Parse(split[4]);


                    if (row1 < 0 || row1 > rows || col1 < 0 || col1 > cols || row2 < 0 || row2 > rows || col2 < 0 || col2 > cols)
                        {
                        Console.WriteLine("Invalid input!");
                        }
                    else
                        {
                        int oldValue = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = oldValue;
                        for (int row = 0; row < rows; row++)
                            {
                            for (int col = 0; col < cols; col++)
                                {
                                Console.Write(matrix[row, col] + " ");
                                }
                            Console.WriteLine();
                            }
                        }
                    }
                else
                    {
                    Console.WriteLine("Invalid input!");
                    }
                }
            }
        }
    }
