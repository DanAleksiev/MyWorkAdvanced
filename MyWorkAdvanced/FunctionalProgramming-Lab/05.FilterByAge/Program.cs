List<Person> people = new List<Person>();
int numOfPeople = int.Parse(Console.ReadLine());

for (int i = 0; i < numOfPeople; i++)
    {
    string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
    people.Add(new Person { Name = input[0], Age = int.Parse(input[1]) });
    }
string filterType = Console.ReadLine();
int filterValue = int.Parse(Console.ReadLine());

Func<Person, int, bool> filter = GetFilter(filterType);

people = people.Where(p => filter(p, filterValue)).ToList();

Action<Person> formatter = GetFormatter(Console.ReadLine());

foreach (var p in people)
    {
    formatter(p);
    }


Func<Person, int, bool> GetFilter(string filter)
    {
    if (filter == "younger")
        {
        return (p, value) => p.Age < value;
        }
    else
        {
        return (p, value) => p.Age >= value;
        }
    }

Action<Person> GetFormatter(string formatingType)
    {
    if (formatingType == "name age")
        {
        return p => Console.WriteLine($"{p.Name} - {p.Age}");
        }
    else if (formatingType == "name")
        {
        return p => Console.WriteLine($"{p.Name}");
        }
    else if (formatingType == "age")
        {
        return p => Console.WriteLine($"{p.Age}");
        }
    return null;
    }
class Person
    {
    public string Name { get; set; }
    public int Age { get; set; }
    }
