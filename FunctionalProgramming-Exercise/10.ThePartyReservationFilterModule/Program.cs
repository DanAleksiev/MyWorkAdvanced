List<string> guestList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
string input;
Dictionary<string, Predicate<string>> filters = new();
while ((input = Console.ReadLine()) != "Print")
    {
    List<string> action = input.Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();
    string command = action[0];
    string filter = action[1];
    string value = action[2];

    if (command == "Add filter")
        {
        filters.Add(filter + value, GetPredicate(filter, value));
        }
    else if (command == "Remove filter")
        {
        filters.Remove(filter + value);
        }
    }

foreach(var filter in filters)
    {
    guestList.RemoveAll(filter.Value);
    }
Console.WriteLine(string.Join(" ", guestList));


static Predicate<string> GetPredicate(string filte, string value)
    {
    switch (filte)
        {
        case "Starts with":
        return s => s.StartsWith(value);
        case "Ends with":
        return s => s.EndsWith(value);
        case "Length":
        return s => s.Length == int.Parse(value);
        case "Contains":
        return s => s.Contains(value);
        default:
        return default;
        }
    }