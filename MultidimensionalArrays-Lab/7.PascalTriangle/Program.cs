namespace _7.PascalTriangle
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArrey = new int[rows][];
            jaggedArrey[0] = new int[1] { 1 };
            for (int row = 1; row < rows; row++)
                {
                jaggedArrey[row] = new int[row + 1];
                for (int col = 0; col < jaggedArrey[row].Length; col++)
                    {
                    if (jaggedArrey[row - 1].Length > col)
                        {
                        jaggedArrey[row][col] += jaggedArrey[row - 1][col];
                        }

                    if (col > 0)
                        {
                        jaggedArrey[row][col] += jaggedArrey[row - 1][col - 1];
                        }
                    Console.Write(jaggedArrey[row][col] + " ");
                    }
                Console.WriteLine();
                }
            }
        }
    }