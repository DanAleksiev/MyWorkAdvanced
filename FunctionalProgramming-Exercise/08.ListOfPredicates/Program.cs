
List<Predicate<int>> precates = new();
int endRange = int.Parse(Console.ReadLine());
HashSet<int> deviders = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

foreach(var devider in deviders)
    {
    //adding a list of predicates with the folowing funktion \/
    precates.Add(n => n % devider == 0);
    }

//creates a array with the given range 1 till endRange
int[] numbers = Enumerable.Range(1,endRange).ToArray();

foreach(var number in numbers)
    {
    bool isDivisable = true;
    foreach(var match in precates)
        {
        if (!match(number))
            {
            isDivisable = false; 
            break;
            }
        }

    if (isDivisable)
        {
        Console.Write($"{number} ");
        }
    }