using System;
using System.IO;

namespace LineNumbers
    {
    public class LineNumbers
        {
        static void Main()
            {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
            }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
            {
            using (StreamReader reader = new StreamReader(inputFilePath))
                {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                    int lineNumber = 0;
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                        {
                        lineNumber++;
                        writer.WriteLine(lineNumber + ". " + line);
                        }
                    }
                }
            }
        }
    }
