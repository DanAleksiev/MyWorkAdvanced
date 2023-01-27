namespace _04.AddVAT
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<double> numbers = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(n=>n*1.2).ToList();

            foreach (var item in numbers)              
                {
                Console.WriteLine($"{item:f2}");
                }
            }
        }
    }