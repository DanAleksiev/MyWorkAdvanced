Func<List<int>, Predicate<int>,List<int>> convertion = (collecton, match) =>
{
    List<int> result = new List<int>();
    foreach (var item in collecton)
        {
        if (!match(item))
            {
            result.Add(item);
            }
        }
    return result.ToList();
};

List<int> collection =Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int devider = int.Parse(Console.ReadLine());

//                                   List<int>       Prediceate 
collection = convertion(collection, n => n % devider == 0);
collection.Reverse();

Console.WriteLine(string.Join(" ",collection));