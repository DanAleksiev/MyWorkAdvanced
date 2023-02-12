namespace _02.RallyRacing
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int size = int.Parse(Console.ReadLine());
            string raceNumber = Console.ReadLine();

            int[] firstTunel = new int[2];
            int[] secondTunel = new int[2];
            int[] finishLine = new int[2];

            string[,] raceTrack = new string[size, size];
            bool isThereFirstTunel = false;
            for (int newRow = 0; newRow < size; newRow++)
                {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int newCol = 0; newCol < size; newCol++)
                    {
                    if (!isThereFirstTunel && input[newCol] == "T")
                        {
                        firstTunel[0] = newRow;
                        firstTunel[1] = newCol;
                        isThereFirstTunel = true;
                        }
                    if (isThereFirstTunel && input[newCol] == "T")
                        {
                        secondTunel[0] = newRow;
                        secondTunel[1] = newCol;
                        }
                    if (input[newCol] == "F")
                        {
                        finishLine[0] = newRow;
                        finishLine[1] = newCol;
                        }
                    raceTrack[newRow, newCol] = input[newCol];
                    }
                }

            int[] raceCarPosition = { 0, 0 };
            int distance = 0;
            string directions = string.Empty;
            int row = 0;
            int col = 0;
            bool passedTunel = false;
            bool completedRace = false;
            while ((directions = Console.ReadLine()) != "End")
                {

                DirectionsAction(directions, ref row, ref col);
                raceCarPosition[0] = row;
                raceCarPosition[1] = col;
                raceTrack[row, col] = "C";

                if (raceCarPosition.SequenceEqual(firstTunel) || raceCarPosition.SequenceEqual(secondTunel))
                    {
                    PassingTrueTunel(firstTunel, secondTunel, raceTrack, raceCarPosition, ref distance, ref row, ref col, ref passedTunel);
                    }
                else if (raceCarPosition.SequenceEqual(finishLine))
                    {
                    distance += 10;
                    Console.WriteLine($"Racing car {raceNumber} finished the stage!");
                    completedRace = true;
                    break;
                    }
                else
                    {
                    distance += 10;
                    }
                //PrintTheMatrix(size, raceTrack);
                raceTrack[row, col] = ".";

                }
            raceTrack[row, col] = "C";

            if (!completedRace)
                {
                Console.WriteLine($"Racing car {raceNumber} DNF.");
                }
            Console.WriteLine($"Distance covered {distance} km.");

            PrintTheMatrix(size, raceTrack);
            }

        private static void PassingTrueTunel(int[] firstTunel, int[] secondTunel, string[,] raceTrack, int[] raceCarPosition, ref int distance, ref int row, ref int col, ref bool passedTunel)
            {
            if (!passedTunel)
                {
                raceTrack[firstTunel[0], firstTunel[1]] = ".";
                raceTrack[secondTunel[0], secondTunel[1]] = ".";

                if (raceCarPosition.SequenceEqual(firstTunel))
                    {
                    row = secondTunel[0];
                    col = secondTunel[1];
                    }
                else
                    {
                    row = firstTunel[0];
                    col = firstTunel[1];
                    }
                raceTrack[row, col] = "C";

                raceCarPosition[0] = row;
                raceCarPosition[1] = col;
                passedTunel = true;
                distance += 30;
                }
            }

        private static void DirectionsAction(string directions, ref int row, ref int col)
            {
            switch (directions)
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

        private static void PrintTheMatrix(int size, string[,] raceTrack)
            {
            for (int newRow = 0; newRow < size; newRow++)
                {

                for (int newCol = 0; newCol < size; newCol++)
                    {
                    Console.Write($"{raceTrack[newRow, newCol]}");
                    }
                Console.WriteLine();
                }
            }
        }
    }