namespace CustomStructures
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            CustomList<string> list = new();

            list.Add("uWu");
            list.Add("lol");
            list.Add("Booo");
            list.Add("loool");
            list.Add("ROFL");

            list[0] = "lols";

            list.AddRange(new string[] {"edno","Dve","tri" });

            Console.WriteLine(list.RemoveAt(2));
            Console.WriteLine(list.RemoveAt(2));
            Console.WriteLine(list.RemoveAt(2));

            Console.WriteLine();

            list.Swap(0, 1);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine(list.Count);
            }
        }
    }