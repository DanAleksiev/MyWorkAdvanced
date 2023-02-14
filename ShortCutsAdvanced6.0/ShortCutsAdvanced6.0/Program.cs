
//queue | stacks 
//short input 
Stack<int> name = new(
    Console.ReadLine()
    .Split(", ")
    .Select(int.Parse));

int[] dailyStamina = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();//first
Stack<int> portionS = new Stack<int>(dailyStamina);


//matrix

//input
int size = int.Parse(Console.ReadLine());
char[,] matrix = new char[size, size];
int[] target = new int[2];
for (int row = 0; row < size; row++)
    {
    char[] line = Console.ReadLine().ToCharArray();
    for (int col = 0; col < size; col++)
        {
        matrix[row, col] = line[col];
        if (line[col] == 'S')
            {
            target[0] = row;
            target[1] = col;
            }
        }
    }

//print
for (int newRow = 0; newRow < size; newRow++)
    {
    for (int newCol = 0; newCol < size; newCol++)
        {
        Console.Write($"{matrix[newRow, newCol]}");
        }
    Console.WriteLine();
    }

//move
int currentRow = target[0];
int currentCol = target[1];
string input = string.Empty;
switch (input)
    {
    case "left":
    currentRow--;
    break;
    case "right":
    currentRow++;
    break;
    case "up":
    currentCol--;
    break;
    case "down":
    currentCol++;
    break;
    }