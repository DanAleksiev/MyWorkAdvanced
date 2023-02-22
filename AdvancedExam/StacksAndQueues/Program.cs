namespace StacksAndQueues
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Queue<int> textiles = new(
    Console.ReadLine()
    .Split(" ")
    .Select(int.Parse));

            Stack<int> medication = new(
    Console.ReadLine()
    .Split(" ")
    .Select(int.Parse));

            Dictionary<int, int> items = new()
                {
                    {30, 0 },
                    {40, 0 },
                    {100,0 },
                };
            Dictionary<string, int> sortableItems = new Dictionary<string, int>()
                {
                    {"Patch",0},
                    {"Bandage",0},
                    {"MedKit",0}
                };
            int leftOvers = 0;
            while (textiles.Count != 0 && medication.Count != 0)
                {
                leftOvers = medication.Pop();
                int value = textiles.Dequeue() + leftOvers;
                if (value > 100)
                    {
                    value -= 100;
                    int addValues = medication.Pop();
                    addValues += value;
                    sortableItems["MedKit"]++;
                    medication.Push(addValues);
                    }
                else if (items.ContainsKey(value))
                    {
                    if (value == 30)
                        {
                        sortableItems["Patch"]++;
                        }
                    if (value == 40)
                        {
                        sortableItems["Bandage"]++;

                        }
                    if (value == 100)
                        {
                        sortableItems["MedKit"]++;
                        }
                    }
                else
                    {
                    leftOvers += 10;
                    medication.Push(leftOvers);
                    }
                }
            if (textiles.Count == 0 && medication.Count == 0)
                {
                Console.WriteLine("Textiles and medicaments are both empty.");
                }
            else if (textiles.Count == 0)
                {
                Console.WriteLine("Textiles are empty.");
                }
            else
                {
                Console.WriteLine("Medicaments are empty.");
                }

            foreach (var item in sortableItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                if (item.Value != 0)
                    {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
            if (medication.Count != 0)
                {
                Console.WriteLine($"Medicaments left: {string.Join(", ", medication)}");
                }
            if (textiles.Count != 0)
                {
                Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
                }
            }
        }
    }