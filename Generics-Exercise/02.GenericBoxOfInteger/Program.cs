namespace GenericsExercise
    {
    internal class StartUp
        {
        static void Main(string[] args)
            {
            int rotations = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < rotations; i++)
                {
                int input = int.Parse(Console.ReadLine());
                box.Add(input);
                }
            Console.WriteLine(box.ToString());
            }
        }
    }