namespace _2.SquaresInMatrix
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

            for (int row = 0; row < rows; row++)
                {
                string[] indexes = Console.ReadLine()
                    .Split();
                for (int col = 0; col < cols; col++)
                    {
                    matrix[row, col] = indexes[col];
                    }
                }

            int count = 0;
            for (int row = 0; row < rows-1; row++)
                {
                for (int col = 0; col < cols-1; col++)
                    {

                    //check if the square has the same values
                    string index = matrix[row, col];
                    string right = matrix[row, col+1];
                    string down = matrix[row+1, col];
                    string downRight = matrix[row + 1, col + 1];

                    if (index == right&& right == down && down == downRight)
                        {
                        count++;
                        }
                    }
                }
            Console.WriteLine(count);
            }
        }
    }