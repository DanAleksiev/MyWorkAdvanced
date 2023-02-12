namespace _02.NavyBattle
    {
    internal class Program
        {
        static void Main(string[] args)
            {

            int[] submarineLocation = new int[2];
            int size = int.Parse(Console.ReadLine());
            char[,] battleField = new char[size, size];
            for (int row = 0; row < size; row++)
                {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                    {
                    battleField[row, col] = line[col];
                    if (line[col] == 'S')
                        {
                        submarineLocation[0] = row;
                        submarineLocation[1] = col;
                        }
                    }
                }

            int hitsLeft = 3;
            int cruisersLeft = 3;

            int currentRow = submarineLocation[0];
            int currentCol = submarineLocation[1];
            string input = string.Empty;
            battleField[currentRow, currentCol] = '-';
            while ((input = Console.ReadLine()) != null)
                {
                MoveTheSubmarine(ref currentRow, ref currentCol, input);
                if (battleField[currentRow, currentCol] == '*')
                    {
                    hitsLeft--;
                    battleField[currentRow, currentCol] = '-';
                    }
                else if (battleField[currentRow, currentCol] == 'C')
                    {
                    cruisersLeft--;
                    battleField[currentRow, currentCol] = '-';
                    }
                if (hitsLeft == 0)
                    {
                    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{currentRow}, {currentCol}]!");
                    break;
                    }
                if (cruisersLeft == 0)
                    {
                    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                    break;
                    }
                }
            battleField[currentRow, currentCol] = 'S';
            for (int newRow = 0; newRow < size; newRow++)
                {
                for (int newCol = 0; newCol < size; newCol++)
                    {
                    Console.Write($"{battleField[newRow, newCol]}");
                    }
                Console.WriteLine();
                }
            }

        private static void MoveTheSubmarine(ref int row, ref int col, string input)
            {
            switch (input)
                {
                case "left":
                col--;
                break;
                case "right":
                col++;
                break;
                case "up":
                row--;
                break;
                case "down":
                row++;
                break;
                }
            }
        }
    }