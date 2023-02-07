namespace GenericScale
    {
    internal class StartUp
        {
       public static void Main(string[] args)
            {
            EqualityScale<int> scale = new EqualityScale<int>(51, 5);
            Console.WriteLine(scale.AreEqual());

            //Console.WriteLine(scale.GetBigger());
            }
        }
    }