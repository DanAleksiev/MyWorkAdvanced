using System;
using System.IO;

namespace _02.Help_A_Mole
    {
    internal class Program
        {
        static void Main(string[] args)
            {

            int size = int.Parse(Console.ReadLine());
            char[,] field = new char[size, size];
            int[] mole = new int[2];
            int[] entrace = new int[2];
            int[] exit = new int[2];
            bool findEntrance = false;
            findEntrance = CreateTheMatrix(size, field, mole, entrace, exit, findEntrance);

            int row = mole[0];
            int col = mole[1];
            string input = string.Empty;
            int molePoint = 0;

            while ((input = Console.ReadLine()) != "End")
                {
                field[row, col] = '-';
                Move(ref row, ref col, input, size);

                if (field[row, col] != '-')
                    {
                    ElseThenDash(field, entrace, exit, findEntrance, ref row, ref col, ref molePoint);
                    }
                field[row, col] = 'M';

                if (molePoint >= 25)
                    {
                    break;
                    }
                //for (int newRow = 0; newRow < size; newRow++)
                //    {
                //    for (int newCol = 0; newCol < size; newCol++)
                //        {
                //        Console.Write($"{field[newRow, newCol]}");
                //        }
                //    Console.WriteLine();
                //    }
            }
            bool win = false;
            field[row, col] = 'M';
            if (molePoint >= 25)
                {
                Console.WriteLine("Yay! The Mole survived another game!");
                win = true;
                }
            else
                {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                }

            if (win)
                {
                Console.WriteLine($"The Mole managed to survive with a total of {molePoint} points.");
                }
            else
                {
                Console.WriteLine($"The Mole lost the game with a total of {molePoint} points.");
                }

            for (int newRow = 0; newRow < size; newRow++)
                {
                for (int newCol = 0; newCol < size; newCol++)
                    {
                    Console.Write($"{field[newRow, newCol]}");
                    }
                Console.WriteLine();
                }
            }
        

    private static bool CreateTheMatrix(int size, char[,] field, int[] mole, int[] entrace, int[] exit, bool findEntrance)
        {
        for (int sihnRow = 0; sihnRow < size; sihnRow++)
            {
            char[] line = Console.ReadLine().ToCharArray();
            for (int sighnRol = 0; sighnRol < size; sighnRol++)
                {
                field[sihnRow, sighnRol] = line[sighnRol];
                if (line[sighnRol] == 'M')
                    {
                    mole[0] = sihnRow;
                    mole[1] = sighnRol;
                    }
                else if (line[sighnRol] == 'S' && !findEntrance)
                    {
                    entrace[0] = sihnRow;
                    entrace[1] = sighnRol;
                    findEntrance = true;
                    }
                else if (line[sighnRol] == 'S')
                    {
                    exit[0] = sihnRow;
                    exit[1] = sighnRol;
                    }
                }
            }

        return findEntrance;
        }

    private static void ElseThenDash(char[,] field, int[] entrace, int[] exit, bool findEntrance, ref int row, ref int col, ref int molePoint)
        {
        if (field[row, col] == 'S')
            {
                field[entrace[0], entrace[1]] = '-';
                field[exit[0], exit[1]] = '-';
            if (findEntrance.Equals(entrace))
                {
                row = exit[0];
                col = exit[1];
                }
            else
                {           
                row = entrace[0];
                col = entrace[1];
                }
            molePoint -= 3;
            }
        if (char.IsDigit(field[row, col]))
            {
            molePoint += int.Parse(field[row, col].ToString());
            }

        field[row, col] = 'M';

        }

    private static void Move(ref int row, ref int col, string input, int size)
        {
        int oldRow = row;
        int oldCol = col;
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
        if (row < 0 || row > size - 1 || col < 0 || col > size - 1)
            {
            Console.WriteLine("Don't try to escape the playing field!");
            row = oldRow;
            col = oldCol;
            }
        }
    }
    }
