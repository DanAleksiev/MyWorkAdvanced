Func<int[], List<int>> requestedNumbers = startEnd =>
{
    int start = startEnd[0];
    int end = startEnd[1];
    List<int> result = new List<int>();
    for (int i = start; i <= end; i++)
        {
        result.Add(i);
        }
    return result;
};

Predicate<int> match;
int[] boundries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string command = Console.ReadLine();

List<int> result = requestedNumbers(boundries);

if(command == "even")
    {
    match = number => number%2 == 0;
    }
else
    {
    match = number => number % 2 != 0;
    }

foreach (var n in result)
    {
    if (match(n))
        {
        Console.Write($"{n} ");
        }
    }