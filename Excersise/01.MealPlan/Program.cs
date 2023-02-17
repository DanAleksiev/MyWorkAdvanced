using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MealPlan
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Queue<string> food =
                new Queue<string>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries));

            Stack<int> caloriesPerDay =
                new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Dictionary<string, int> caloriesPerMeal = new Dictionary<string, int>()
                {
                    {"salad", 350},
                    {"soup", 490},
                    {"pasta", 680},
                    {"steak", 790},
                };

            int sumOfCalories = 0;
            int leftovers = 0;
            int daylyCal = 0;
            int countOfMeals = 0;

            while (food.Count != 0 || leftovers != 0)
                {
                if (daylyCal == 0)
                    {
                    if (caloriesPerDay.Count == 0)
                        {
                        break;
                        }
                    daylyCal = caloriesPerDay.Pop();
                    if (leftovers != 0)
                        {
                        daylyCal -= leftovers;
                        leftovers = 0;
                        if (food.Count == 0)
                            {
                            break;
                            }
                        }
                    }
                int currentCal = caloriesPerMeal[food.Dequeue()];
                if (daylyCal - currentCal <= 0)
                    {
                    leftovers = currentCal - daylyCal;
                    daylyCal = 0;
                    countOfMeals++;
                    }
                else
                    {
                    daylyCal -= currentCal;
                    countOfMeals++;
                    }
                }
            caloriesPerDay.Push(daylyCal);
            if (food.Count != 0)
                {
                Console.WriteLine($"John ate enough, he had {countOfMeals} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", food)}.");
                }
            else
                {
                Console.WriteLine($"John had {countOfMeals} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", caloriesPerDay)} calories.");
                }
            }
        }
    }
