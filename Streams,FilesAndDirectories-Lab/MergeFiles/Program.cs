using System;
using System.IO;

namespace MergeFiles
    {
    public class MergeFiles
        {
        static void Main()
            {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
            }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
            {
            using (StreamReader readInput1 = new StreamReader(firstInputFilePath))
                {
                using (StreamReader readInput2 = new StreamReader(secondInputFilePath))
                    {
                    using (StreamWriter output = new StreamWriter(outputFilePath))
                        {
                        bool notNull = true;
                        while (notNull)
                            {
                            string line1 = readInput1.ReadLine();
                            string line2 = readInput2.ReadLine();
                            if (line1 == null && line2 == null)
                                {
                                notNull = false;
                                }

                            if (line1 != null)
                                {
                                output.WriteLine(line1);
                                }
                            if (line2 != null)
                                {
                                output.WriteLine(line2);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
