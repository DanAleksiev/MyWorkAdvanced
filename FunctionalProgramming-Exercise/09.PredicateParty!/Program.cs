List<string> guestList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
string input;
while ((input = Console.ReadLine()) != "Party!")
    {
    List<string> action = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
    string command = action[0];
    string filter = action[1];
    string value = action[2];

    if (command == "Remove")
        {
        guestList.RemoveAll(GetPredicate(filter, value));
        }
    else if (command == "Double")
        {
        List<string> peopleToBeDoubled = guestList.FindAll(GetPredicate(filter, value));
        foreach (var person in peopleToBeDoubled)
            {
            int index = guestList.FindIndex(p => p == person);
            guestList.Insert(index, person);
            }
        }
    }
if (guestList.Count > 0)
    {
    Console.WriteLine($"{string.Join(", ", guestList)} are going to the party!");
    }
else
    {
    Console.WriteLine("Nobody is going to the party!");
    }

static Predicate<string> GetPredicate(string filte, string value)
    {
    switch (filte)
        {
        case "StartsWith":
        return s => s.StartsWith(value);
        case "EndsWith":
        return s => s.EndsWith(value);
        case "Length":
        return s => s.Length == int.Parse(value);
        default:
        return default;
        }
    }