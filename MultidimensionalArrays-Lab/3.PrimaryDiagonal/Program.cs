namespace _3.PrimaryDiagonal
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int rowsCol = int.Parse(Console.ReadLine());
            int[,]squarMatrix = new int[rowsCol, rowsCol];

            for (int row = 0; row < squarMatrix.GetLength(0); row++)
                {
                int[] colsElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < squarMatrix.GetLength(1); col++)
                    {
                    squarMatrix[row, col] = colsElements[col];
                    }
                }

            //sum diagonls left to right
            int sum = 0;
            for (int i = 0; i < squarMatrix.GetLength(0); i++)
                {
                sum += squarMatrix[i,i];
                //Console.WriteLine(squarMatrix[i, i] + " ");
                }
            Console.WriteLine(sum);
            //sum diagonals right to left
            //int sum2 = 0;
            //for (int i = 0; i < squarMatrix.GetLength(0); i++)
            //    {
            //    sum += squarMatrix[squarMatrix.GetLength(0)-i-1, i];
            //    Console.WriteLine(squarMatrix[squarMatrix.GetLength(0) - i - 1, i] + " ");
            //    }

            //Console.WriteLine($"Sum: {sum}|Sum2: {sum2}");
            }
        }
    }