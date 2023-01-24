namespace EvenLines
    {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml;

    public class EvenLines
        {
        static void Main()
            {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath));
            }

        public static string ProcessLines(string inputFilePath)
            {
            using (StreamReader reader = new StreamReader(inputFilePath))
                {
                string input;
                int line = 0;
                string formatedLine = string.Empty;
                while ((input = reader.ReadLine()) != null)
                    {
                    Stack<string> wordsBackwords = new Stack<string>();
                    if (line % 2 == 0)
                        {
                        string[] words = input.Split(" ");
                        char[] unwantedSimbals = { '-', ',', '.', '!', '?' };
                        char replacement = '@';
                        for (int w = 0; w < words.Length; w++)
                            {
                            for (int i = 0; i < unwantedSimbals.Length; i++)
                                {
                                char currentChar = unwantedSimbals[i];
                                List<char> splitword = words[w].ToList();
                                if (splitword.Contains(currentChar))
                                    {
                                    for (int ch = 0; ch < splitword.Count; ch++)
                                        {
                                        if (splitword[ch] == currentChar)
                                            {
                                            splitword.Remove(currentChar);
                                            splitword.Insert(ch, replacement);
                                            }
                                        words[w] = string.Join("", splitword);
                                        }
                                    }
                                }
                            wordsBackwords.Push(words[w]);
                            }

                        Console.WriteLine(string.Join(" ", wordsBackwords));
                        }

                    line++;

                    }
                string output =string.Empty;
                return output;
                }

            }
        }
    }
