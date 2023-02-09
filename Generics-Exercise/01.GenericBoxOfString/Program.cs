namespace GenericsExercise
    {
    internal class StartUp
        {
        static void Main(string[] args)
            {
            int rotations = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < rotations; i++)
                {
                string input = Console.ReadLine();
                box.Add(input);
                }
            Console.WriteLine(box.ToString());
            }
        }
    }