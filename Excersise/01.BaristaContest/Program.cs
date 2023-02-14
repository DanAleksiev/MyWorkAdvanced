namespace _01.BaristaContest
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] quantityOfCoffee = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); //last
            int[] quantityOfMilk = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();//first
            Queue<int> coffeeQ = new Queue<int>(quantityOfCoffee);
            Stack<int> milkQ = new Stack<int>(quantityOfMilk);

            List<string> coffees = new();
            coffees.Add("Cortado 50");
            coffees.Add("Espresso 75");
            coffees.Add("Capuccino 100");
            coffees.Add("Americano 150");
            coffees.Add("Latte 200");

            Dictionary<string, int> doneDrinks = new Dictionary<string, int>();

            while (coffeeQ.Count != 0 && milkQ.Count != 0)
                {
                int currentCoffee = coffeeQ.Dequeue();
                int currentMilk = milkQ.Pop();
                int value = currentCoffee + currentMilk;
                bool wasThereCoffee = false;
                for (int i = 0; i < coffees.Count; i++)
                    {
                    string[] currentRequremnts = coffees[i].Split(" ");
                    string coffeType = currentRequremnts[0];
                    int MGRequred = int.Parse(currentRequremnts[1]);

                    if (value == MGRequred)
                        {
                        if (!doneDrinks.ContainsKey(coffeType))
                            {
                            doneDrinks[coffeType] = 0;
                            }
                        doneDrinks[coffeType]++;
                        wasThereCoffee = true;
                        break;
                        }
                    }
                if (!wasThereCoffee)
                    {
                    currentMilk -= 5;
                    milkQ.Push(currentMilk);
                    }
                }

            Print(coffeeQ, milkQ, doneDrinks);
            }

        private static void Print(Queue<int> coffeeQ, Stack<int> milkQ, Dictionary<string, int> doneDrinks)
            {
            if (coffeeQ.Count == 0 && milkQ.Count == 0)
                {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
                }
            else
                {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
                }

            if (coffeeQ.Count > 0)
                {
                Console.WriteLine($"Coffee left: {string.Join(", ", coffeeQ)}");
                }
            else
                {
                Console.WriteLine("Coffee left: none");
                }

            if (milkQ.Count > 0)
                {
                Console.WriteLine($"Coffee left: {string.Join(", ", milkQ)}");
                }
            else
                {
                Console.WriteLine("Milk left: none");
                }

            foreach (var coffee in doneDrinks.OrderBy(c => c.Value).ThenByDescending(c => c.Key))
                {
                Console.WriteLine($"{coffee.Key}: {coffee.Value}");
                }
            }
        }
    }