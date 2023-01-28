Func<int[], string, int[]> actions = (numbers, command) =>
{
    switch (command)
        {
        case "add":       
        for (int i = 0; i < numbers.Length; i++)
            {
            numbers[i] += 1;
            }
        break;
        
        case "multiply":
        for (int i = 0; i < numbers.Length; i++)
            {
            numbers[i] *= 2;
            }
        break;

        case "subtract":   
        for (int i = 0; i < numbers.Length; i++)
            {
            numbers[i] -= 1;
            }
        break;
        }

    return numbers;
};
int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string command;
while ((command = Console.ReadLine()) != "end")
    {
    if (command == "print")
        {
        Console.WriteLine(string.Join(" ", numbers));
        }
    else
        {
        actions(numbers, command);
        }
    }
