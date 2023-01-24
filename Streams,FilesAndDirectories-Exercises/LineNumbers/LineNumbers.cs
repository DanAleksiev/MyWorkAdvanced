namespace LineNumbers
    {
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
        {
        static void Main()
            {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
            }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
            {
            string[] lines = File.ReadAllLines(inputFilePath);
            //StringBuilder sb = new StringBuilder();

            for (int line = 0; line < lines.Length; line++)
                {
                int lettes = 0;
                int punctuatetions = 0;

                //int lettersCount = lines[line].Count(char.IsLetter);
                //int puncCount = lines[line].Count(char.IsPunctuation);
                char[] chars = lines[line].ToCharArray();
                foreach (char c in chars)
                    {
                    if (char.IsLetter(c))
                        {
                        lettes++;
                        }
                    else if (char.IsPunctuation(c))
                        {
                        punctuatetions++;
                        }
                    }
                lines[line] = $"Line {line + 1}: {lines[line]} ({lettes})({punctuatetions})";
               // sb.AppendLine($"Line {line + 1}: {lines[line]} ({lettes})({punctuatetions})");
                }

            File.WriteAllLines(outputFilePath, lines);
            }
        }
    }
