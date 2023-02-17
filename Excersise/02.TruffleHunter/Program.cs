using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace _02.TruffleHunter
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];

            for (int row = 0; row < size; row++)
                {
                string[] inputLines = Console.ReadLine().Split(" ");
                for (int col = 0; col < size; col++)
                    {
                    matrix[row, col] = inputLines[col];
                    }
                }

            Dictionary<string, int> colected
                = new Dictionary<string, int>() {
                    {"B",0 },
                    {"S",0 },
                    {"W",0 },

                };
            int countBoreTruffles = 0;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Stop the hunt")
                {
                string[] command = input.Split(" ");
                string action = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                switch (action)
                    {
                    case "Collect":
                    if (matrix[row, col] != "-")
                        {
                        colected[matrix[row, col]]++;
                        matrix[row, col] = "-";
                        }
                    break;
                    case "Wild_Boar":
                    string direction = command[3];
                    int count = 0;

                    switch (direction)
                        {
                        case "up":
                        for (int i = row; i >= 0; i--)
                            {
                            if (count % 2 == 0)
                                {
                                if (matrix[i, col] != "-")
                                    {
                                    countBoreTruffles++;
                                    matrix[i, col] = "-";
                                    }
                                }
                            count++;
                            }
                        break;

                        case "down":
                        for (int i = row; i < size; i++)
                            {
                            if (count % 2 == 0)
                                {
                                if (matrix[i, col] != "-")
                                    {
                                    countBoreTruffles++;
                                    matrix[i, col] = "-";
                                    }
                                }
                            count++;
                            }
                        break;

                        case "left":
                        for (int i = col; i >= 0; i--)
                            {
                            if (count % 2 == 0)
                                {
                                if (matrix[row, i] != "-")
                                    {
                                    countBoreTruffles++;
                                    matrix[row, i] = "-";
                                    }
                                }
                            count++;
                            }
                        break;

                        case "right":
                        for (int i = col; i < size; i++)
                            {
                            if (count % 2 == 0)
                                {
                                if (matrix[row, i] != "-")
                                    {
                                    countBoreTruffles++;
                                    matrix[row, i] = "-";
                                    }
                                }
                            count++;
                            }
                        break;
                        }
                    break;
                    }
                }
            Console.WriteLine($"Peter manages to harvest {colected["B"]} black, {colected["S"]} summer, and {colected["W"]} white truffles.");
            Console.WriteLine($"The wild boar has eaten {countBoreTruffles} truffles.");
            Print(size, matrix);
            }

        private static void Print(int size, string[,] matrix)
            {
            for (int newRow = 0; newRow < size; newRow++)
                {
                for (int newCol = 0; newCol < size; newCol++)
                    {
                    Console.Write($"{matrix[newRow, newCol]} ");
                    }
                Console.WriteLine();
                }
            }
        }
    }
