namespace RecursiveFactorial
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            //Console.WriteLine("Give a number to be returned in Factorial: ");
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------------");
            Console.WriteLine(Factorial(n));
            }
        static int Factorial(int n)
            {
            if (n == 1)
                {
                return 1;
                }
            return n * Factorial(n - 1);
            }
        }
    }