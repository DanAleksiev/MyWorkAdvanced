namespace Matrix
    {
    internal class Program
        {
        static void Main(string[] args)
            {

            int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[size[0], size[1]];
            int[] player = new int[2];
            for (int row = 0; row < size[0]; row++)
                {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < size[1]; col++)
                    {
                    matrix[row, col] = line[col];
                    if (line[col] == "B")
                        {
                        player[0] = row;
                        player[1] = col;
                        }
                    }
                }

            string input = string.Empty;
            int currentRow = player[0];
            int currentCol = player[1];
            int numberOfOtherPlayers = 3;
            int moves = 0;
            int oponentsDeltWith = 0;

            while ((input = Console.ReadLine()) != "Finish" && oponentsDeltWith != numberOfOtherPlayers)
                {
                matrix[currentRow, currentCol] = "-";
                int oldPositionRow = currentRow;
                int oldPositionCol = currentCol;
                MakeAmove(size, input, ref currentRow, ref currentCol, ref moves);
                if (currentRow < 0 || currentRow >= size[0] || currentCol < 0 || currentCol >= size[1])
                    {
                    currentRow = oldPositionRow;
                    currentCol = oldPositionCol;
                    continue;
                    }
                else
                    {
                    moves++;
                    }
                if (matrix[currentRow, currentCol] != "-")
                    {
                    if (matrix[currentRow, currentCol] == "P")
                        {
                        oponentsDeltWith++;
                        matrix[currentRow, currentCol] = "-";
                        }
                    else
                        {
                        currentRow = oldPositionRow;
                        currentCol = oldPositionCol;
                        moves--;
                        }
                    }
                matrix[currentRow, currentCol] = "B";
                }


            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {oponentsDeltWith} Moves made: {moves}");
            }

        private static void MakeAmove(int[] size, string input, ref int currentRow, ref int currentCol, ref int moves)
            {
            switch (input)
                {
                case "up":
                currentRow--;
                break;
                case "down":
                currentRow++;
                break;
                case "left":
                currentCol--;
                break;
                case "right":
                currentCol++;
                break;
                }
            }

        private static void Print(int[] size, string[,] matrix)
            {
            for (int newRow = 0; newRow < size[0]; newRow++)
                {
                for (int newCol = 0; newCol < size[1]; newCol++)
                    {
                    Console.Write($"{matrix[newRow, newCol]}");
                    }
                Console.WriteLine();
                }
            }
        }
    }