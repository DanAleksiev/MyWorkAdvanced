using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
    {
    public class WordCount
        {
        static void Main()
            {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
            }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
            {
            using (StreamWriter output = new StreamWriter(outputFilePath))
                {
                Dictionary<string, int> usedWords = new Dictionary<string, int>();
                using (StreamReader text = new StreamReader(textFilePath))
                    {
                    using (StreamReader words = new StreamReader(wordsFilePath))
                        {
                        string[] listOfWords = words.ReadLine().Split(" ");
                        string line = string.Empty;

                        while ((line = text.ReadLine()) != null)
                            {
                            List<string> wordInLine = line.ToLower().Split(" ").ToList();
                            for (int wordOfLine = 0; wordOfLine < wordInLine.Count; wordOfLine++)
                                {
                                string oldWord = wordInLine[wordOfLine];
                                List<char> currentWordOfLine = wordInLine[wordOfLine].ToList();

                                for (int chr = 0; chr < currentWordOfLine.Count; chr++)
                                    {
                                    char currentChar = currentWordOfLine[chr];
                                    if (currentChar < 97)
                                        {
                                        currentWordOfLine.Remove(currentChar);
                                        }
                                    }
                                string editedWord = string.Join("", currentWordOfLine);
                                wordInLine[wordOfLine] = editedWord;
                                }
                            for (int targetedWord = 0; targetedWord < listOfWords.Length; targetedWord++)
                                {
                                for (int currentWordOfList = 0; currentWordOfList < wordInLine.Count; currentWordOfList++)
                                    {
                                        {
                                        if (listOfWords[targetedWord] == wordInLine[currentWordOfList])
                                            {
                                            if (!usedWords.ContainsKey(listOfWords[targetedWord]))
                                                {
                                                usedWords.Add(listOfWords[targetedWord], 0);
                                                }
                                            usedWords[listOfWords[targetedWord]]++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                foreach (var word in usedWords.OrderByDescending(x=>x.Value))
                    {
                    output.WriteLine(word.Key + " - " + word.Value);
                    }
                }
            }
        }
    }
