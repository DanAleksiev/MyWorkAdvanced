namespace _6.JaggedArrayManipulator
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
                {
                int[] splitInput = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                matrix[row] = new int[splitInput.Length];
                for (int col = 0; col < matrix[row].Length; col++)
                    {
                    matrix[row][col] = splitInput[col];
                    }
                }

            //analise and multiply / devide
            for (int row = 0; row < rows-1; row++)
                {
                if (matrix[row].Length == matrix[row + 1].Length)
                    {
                    for (int i = row; i <= row+1; i++)
                        {
                        for (int col = 0; col < matrix[i].Length; col++)
                            {
                            matrix[i][col] *= 2;
                            }
                        }
                    }
                else
                    {
                    for (int i = row; i <= row + 1; i++)
                        {
                        for (int col = 0; col < matrix[i].Length; col++)
                            {
                            matrix[i][col] /= 2;
                            }
                        }
                    }
                }

            string input;
            while ((input = Console.ReadLine()) != "End")
                {
                string[] splitInput = input
                    .Split();
                string action = splitInput[0];
                int row = int.Parse(splitInput[1]);
                int col = int.Parse(splitInput[2]);
                int value = int.Parse(splitInput[3]);
                if (row >= 0 && col >= 0 && row < rows && col < matrix[row].Length)
                    {
                    if (action == "Add")
                        {
                        matrix[row][col] += value;
                        }
                    else if (action == "Subtract")
                        {
                        matrix[row][col] -= value;
                        }
                    }
                }

            for (int row = 0; row < rows; row++)
                {
                for (int col = 0; col < matrix[row].Length; col++)
                    {
                    Console.Write(matrix[row][col] + " ");
                    }
                Console.WriteLine();
                }
            }
        }
    }