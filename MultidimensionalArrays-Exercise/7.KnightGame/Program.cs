using System.Text;

namespace _7.KnightGame
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int rowsCols = int.Parse(Console.ReadLine());

            char[,] matrix = new char[rowsCols, rowsCols];
            for (int row = 0; row < rowsCols; row++)
                {
                string input = Console.ReadLine();
                for (int col = 0; col < rowsCols; col++)
                    {
                    matrix[row, col] = input[col];
                    }
                }

            int eliminated = 0;
            while (true)
                {
                int mostDangerous = 0;
                StringBuilder coordinates = new StringBuilder();
                for (int row = 0; row < rowsCols; row++)
                    {

                    for (int col = 0; col < rowsCols; col++)
                        {
                        if (matrix[row, col] == 'K')
                            {
                            int readyToAttack = NumOfAttack(row, col);


                            if (mostDangerous < readyToAttack)
                                {
                                coordinates.Clear();
                                mostDangerous = readyToAttack;
                                coordinates.Append(row + " ");
                                coordinates.Append(col);
                                }
                            }

                        }
                    }
                if (mostDangerous != 0)
                    {
                    int[] split = coordinates.ToString().Split().Select(int.Parse).ToArray();
                    matrix[split[0], split[1]] = '0';
                    eliminated++;
                    }
                else
                    {
                    break;
                    }

                }
            Console.WriteLine(eliminated);

       int NumOfAttack(int row, int col)
            {
            int readyToAttack = 0;
            if (IsLocationValid(row + 2, col + 1))
                {
                if (matrix[row + 2, col + 1] == 'K')
                    {
                    readyToAttack++;
                    }
                }
            if (IsLocationValid(row + 2, col - 1))
                {
                if (matrix[row + 2, col - 1] == 'K')
                    {
                    readyToAttack++;
                    }
                }
            if (IsLocationValid(row - 2, col + 1))
                {
                if (matrix[row - 2, col + 1] == 'K')
                    {
                    readyToAttack++;
                    }
                }
            if (IsLocationValid(row - 2, col - 1))
                {
                if (matrix[row - 2, col - 1] == 'K')
                    {
                    readyToAttack++;
                    }
                }
            if (IsLocationValid(row + 1, col + 2))
                {
                if (matrix[row + 1, col + 2] == 'K')
                    {
                    readyToAttack++;
                    }
                }
            if (IsLocationValid(row + 1, col - 2))
                {
                if (matrix[row + 1, col - 2] == 'K')
                    {
                    readyToAttack++;
                    }
                }
            if (IsLocationValid(row - 1, col + 2))
                {
                if (matrix[row - 1, col + 2] == 'K')
                    {
                    readyToAttack++;
                    }
                }
            if (IsLocationValid(row - 1, col - 2))
                {
                if (matrix[row - 1, col - 2] == 'K')
                    {
                    readyToAttack++;
                    }
                }
            return readyToAttack;
            }
            bool IsLocationValid(int row, int col)
                {
                return row >= 0 && row < rowsCols && col >= 0 && col < rowsCols;
                }
            }

        }
    }