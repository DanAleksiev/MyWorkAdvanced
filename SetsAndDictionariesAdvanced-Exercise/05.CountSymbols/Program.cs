using System;
using System.Collections.Generic;

namespace _05.CountSymbols
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            char[] text = Console.ReadLine().ToCharArray();

            SortedDictionary<char, int> acurances = new SortedDictionary<char, int>();

            foreach (char c in text)
                {
                if (!acurances.ContainsKey(c))
                    {
                    acurances[c] = 0;
                    }
                acurances[c]++;
                }

            foreach (var character in acurances)
                {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
                }
            }
        }
    }
