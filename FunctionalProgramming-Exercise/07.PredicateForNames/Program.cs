using System;

Func<List<string>, Predicate<string>, List<string>> alowedNames = (people, match) =>
{
    List<string> names = new List<string>();

    foreach (var person in people)
        {
        if (match(person))
            {
            names.Add(person);
            }
        }
    return names.ToList();
};
int lenght = int.Parse(Console.ReadLine());
List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();


people = alowedNames(people, names => names.Length <=lenght);

Console.WriteLine(string.Join(System.Environment.NewLine, people));


