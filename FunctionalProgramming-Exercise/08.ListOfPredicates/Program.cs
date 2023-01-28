
List<Predicate<int>> precates = new();
int endRange = int.Parse(Console.ReadLine());
HashSet<int> deviders = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

foreach(var devider in deviders)
    {
    precates.Add(n=>n%devider)
    }