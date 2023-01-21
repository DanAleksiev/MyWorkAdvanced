using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int numOfUsers = int.Parse(Console.ReadLine());
            HashSet<string> users = new HashSet<string>();
            for (int i = 0; i < numOfUsers; i++)
                {
                users.Add(Console.ReadLine());
                }
            foreach (string user in users)
                {
                Console.WriteLine(user);
                }
            }
        }
    }
