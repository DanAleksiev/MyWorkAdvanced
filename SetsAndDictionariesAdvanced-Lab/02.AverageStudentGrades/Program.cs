using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int students = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> result = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < students; i++)
                {
                string[] stude= Console.ReadLine().Split(' ');
                string name = stude[0];
                decimal grade = decimal.Parse(stude[1]);
                if (!result.ContainsKey(name))
                    {
                    result.Add(name,new List<decimal>());
                    }
                    result[name].Add(grade);
                }
            foreach (var student in result)
                {
                Console.WriteLine($"{student.Key} -> {string.Join(" ",student.Value.Select(s=>s.ToString("F2")))} (avg: {student.Value.Average():f2})");
                }
            }
        }
    }
