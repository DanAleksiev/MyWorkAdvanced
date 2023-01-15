namespace _5.SquareWithMaximumSum
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] parameter = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToArray();

            int rows = parameter[0];
            int cols = parameter[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
                {
                int[] colsElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                    matrix[row, col] = colsElements[col];
                    }
                }

            int sum = int.MinValue;
            string top = string.Empty;
            string bottom = string.Empty;
            for (int row = 0; row < rows - 1; row++)
                {
                for (int col = 0; col < cols - 1; col++)
                    {
                    int currentSum = 0;
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > sum)
                        {
                        sum = currentSum;
                        top = $"{matrix[row, col].ToString()} {matrix[row, col + 1].ToString()}";
                        bottom = $"{matrix[row + 1, col].ToString()} {matrix[row+1, col + 1].ToString()}";
                        }
                    }
                }
            Console.WriteLine(top);
            Console.WriteLine(bottom);
            Console.WriteLine(sum);
            }
        }
    }