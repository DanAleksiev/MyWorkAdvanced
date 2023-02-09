namespace test
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Tuple<string, int> nameAge = Tuple.Create("Dan", 27);
            (int age, string name) = (27, "Lucy");

            Console.WriteLine(nameAge);
            Console.WriteLine(nameAge.Item1);
            Console.WriteLine(nameAge.Item2);
            Console.WriteLine("--------------");
            Console.WriteLine(name);
            Console.WriteLine(age);
            }
        }
    }