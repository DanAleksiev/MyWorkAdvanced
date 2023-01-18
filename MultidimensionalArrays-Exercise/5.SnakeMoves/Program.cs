namespace _5.SnakeMoves
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
            string[,] matrix = new string[rows, cols];

            string snake = Console.ReadLine();

            int lastIndex = 0;
            for (int row = 0; row < rows; row++)
                {
                if (row % 2 == 0)
                    {
                    for (int col = 0; col < cols; col++)
                        {
                        if (lastIndex < snake.Length)
                            {
                            matrix[row, col] = snake[lastIndex].ToString();
                            lastIndex++;
                            }
                        else
                            {
                            lastIndex = 0;
                            matrix[row, col] = snake[lastIndex].ToString();
                            lastIndex++;
                            }
                        }

                    }
                else
                    {
                    for (int col = cols - 1; col >= 0; col--)
                        {
                        if (lastIndex < snake.Length)
                            {
                            matrix[row, col] = snake[lastIndex].ToString();
                            lastIndex++;
                            }
                        else
                            {
                            lastIndex = 0;
                            matrix[row, col] = snake[lastIndex].ToString();
                            lastIndex++;
                            }
                        }
                    }
                }

            for (int row = 0; row < rows; row++)
                {
                for (int col = 0; col < cols; col++)
                    {
                    Console.Write(matrix[row, col]);
                    }
                Console.WriteLine();
                }
            }
        }
    }