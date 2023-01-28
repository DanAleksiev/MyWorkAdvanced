Func<int[], int> smallestNumber = n =>
// easy way
//Func<int[], int> smallestNumber = n => n.Min

{
    int min = int.MaxValue;
    foreach (var num in n)
        {
        if (num < min)
            {
            min = num;
            }
        }
    return min;

};
int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Console.WriteLine(smallestNumber(input));
