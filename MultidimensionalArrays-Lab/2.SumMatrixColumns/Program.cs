namespace _2.SumMatrixColumns
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
                int[] colsElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                    matrix[row, col] = colsElements[col];                  
                    }
                }
            //sum every colum
            for (int col = 0; col < matrix.GetLength(1); col++)
                {
                int sum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                    sum += matrix[row, col];
                    }
                Console.WriteLine(sum);
                }
            }
        }
    }