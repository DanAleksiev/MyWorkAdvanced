namespace GenericArrayCreator
    {
    internal class StartUp
        {
        static void Main(string[] args)
            {
            string[] stringArr = ArrayCreator.Create(5,"Dimitrichko");
            int[] intArr = ArrayCreator.Create(100, 3);

            Console.WriteLine(string.Join(" ", stringArr));
            Console.WriteLine(string.Join(" ", intArr));
            }
        }
    }