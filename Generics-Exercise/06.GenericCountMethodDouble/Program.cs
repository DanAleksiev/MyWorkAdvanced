namespace GenericsExercise
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int rotations = int.Parse(Console.ReadLine());

            //string
            //Box<string> box = new Box<string>();
            //for (int i = 0; i < rotations; i++)
            //    {
            //    string input = Console.ReadLine();
            //    box.Add(input);
            //    }

            //int
            //Box<int> box = new Box<int>();
            //for (int i = 0; i < rotations; i++)
            //    {
            //    int input = int.Parse(Console.ReadLine());
            //    box.Add(input);
            //    }

            //double
            Box<double> box = new Box<double>();
            for (int i = 0; i < rotations; i++)
                {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
                }

            //string target = Console.ReadLine();
            double target = double.Parse(Console.ReadLine());

            //int[] replace = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //box.Replace(replace[0], replace[1]);
            //Console.WriteLine(box.ToString());
            Console.WriteLine(box.Compare(target));
            }
        }
    }