using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int loops = int.Parse(Console.ReadLine());

            Dictionary<int,int>everyNum= new Dictionary<int,int>();
            for (int i = 0; i < loops; i++)
                {
                int input= int.Parse(Console.ReadLine());
                if (!everyNum.ContainsKey(input))
                    {
                    everyNum[input]=0;
                    }
                everyNum[input]++;
                }
            Console.WriteLine(everyNum.Single(x => x.Value % 2 == 0).Key);
            }
        }
    }
