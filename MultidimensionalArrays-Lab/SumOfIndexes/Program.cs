namespace SumOfIndexes
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
                {
                for (int col = 0; col < cols; col++)
                    {
                    matrix[row, col] = row + col;
                    }
                }

            for (int row = 0; row < rows; row++)
                {
                for (int col = 0; col < cols; col++)
                    {
                    if (matrix[row, col] < 10)
                        {
                        Console.Write($" {matrix[row, col]} ");

                        }
                    else
                        {
                        Console.Write($"{matrix[row, col]} ");

                        }
                    }
                Console.WriteLine();
                }
            }
        }
    }