namespace _07.Tuple
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            //Tuple<string,string> tuple =
            string[] firstLine = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string[] secondLine = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string[] thirdLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = $"{firstLine[0]} {firstLine[1]}";
            string address = firstLine[2] ;
            CustomTuple<string,string> line1 = new (name,address);

            string name2 = secondLine[0] ;
            int beersToDrink = int.Parse(secondLine[1]) ;
            CustomTuple<string, int> line2 = new (name2, beersToDrink);

            int num1 = int.Parse(thirdLine[0]) ;
            double num2 = double.Parse(thirdLine[1]) ;
            CustomTuple<double, double> line3 = new (num1, num2);

            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);

            }
        }
    }