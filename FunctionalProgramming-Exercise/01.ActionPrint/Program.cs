
List<string> people = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
Action<string> printName = name => Console.WriteLine(name);
people.ForEach(printName);


