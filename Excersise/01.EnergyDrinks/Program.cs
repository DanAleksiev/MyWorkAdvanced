namespace _01.EnergyDrinks
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] coffein = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] drink = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stackOfSubstance = new Stack<int>(coffein);
            Queue<int> drinks = new Queue<int>(drink);

            int takenCoffein = 0;
            int limit = 300;

            while (stackOfSubstance.Count != 0 && drinks.Count != 0)
                {
                int currentCoffein = stackOfSubstance.Pop();
                int currentDrink = drinks.Dequeue();
                int value = currentCoffein * currentDrink;
                if (value + takenCoffein <= limit)
                    {
                    takenCoffein += value;
                    }
                else
                    {
                    drinks.Enqueue(currentDrink);
                    takenCoffein -= 30;
                    if (takenCoffein < 0)
                        {
                        takenCoffein = 0;
                        }
                    }
                }

            if (drinks.Count != 0)
                {
                Console.WriteLine("Drinks left: " + string.Join(", ", drinks));
                }
            else
                {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
                }
            Console.WriteLine($"Stamat is going to sleep with {takenCoffein} mg caffeine.");
            }
        }
    }