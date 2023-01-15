namespace _1.SumMatrixElements
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
            // set values to each individual block
            for (int row = 0; row < matrix.GetLength(0); row++)
                {
                int[] colsElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                    matrix[row, col] = colsElements[col];
                    }
                }

            int sum = 0;
            //sum the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
                {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                    sum += matrix[row, col];
                    }
                }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
            //print ot the matrix
            //
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //    {
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //        {
            //        Console.WriteLine("{0}", matrix[rows, cols]);
            //        }
            //    Console.WriteLine();
            //    }
            //
            //or
            //
            //foreach (int element in matrix)
            //    {
            //    Console.WriteLine(element + " ");
            //    }

            }
        }
    }
