namespace MultidimensionalArrays_Exercise
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int parametre = int.Parse(Console.ReadLine());
            int[,] matrix = new int[parametre, parametre];

            for (int row = 0; row < parametre; row++)
                {
                int[] split = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < parametre; col++)
                    {
                    matrix[row, col] = split[col];
                    }
                }

            //calculates the sums of the diagonals and gives the absolute
            int sumLeft = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                {
                sumLeft += matrix[i, i];
                }

            int sumRight = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                {
                sumRight += matrix[matrix.GetLength(0) - i - 1, i];
                }

            Console.WriteLine(Math.Abs(sumLeft - sumRight));
            }
        }
    }