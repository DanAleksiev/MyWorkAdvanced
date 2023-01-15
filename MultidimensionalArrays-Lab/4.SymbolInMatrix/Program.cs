namespace _4.SymbolInMatrix
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int rowsCol = int.Parse(Console.ReadLine());
            char[,] squarMatrix = new char[rowsCol, rowsCol];

            for (int row = 0; row < rowsCol; row++)
                {
                char[] colsElements = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < squarMatrix.GetLength(1); col++)
                    {
                    squarMatrix[row, col] = colsElements[col];
                    }
                }
            char simbol = char.Parse(Console.ReadLine());
            bool exist = false;
            for (int row = 0; row < rowsCol; row++)
                {
                for (int col = 0; col < rowsCol; col++)
                    {
                    if (simbol == squarMatrix[row, col])
                        {
                        exist = true;
                        Console.WriteLine($"({row}, {col})");
                        break;
                        }
                    }
                if (exist) { break; }
                }
            if (!exist)
                {
                Console.WriteLine($"{simbol} does not occur in the matrix");
                }

            }
        }
    }