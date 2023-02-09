namespace _08.Threeuple
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            //Tuple<string,string> tuple =
            string[] firstLine = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string[] secondLine = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string[] thirdLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name1 = $"{firstLine[0]} {firstLine[1]}";
            string address = firstLine[2] ;
            string town = string.Join(" ",firstLine[3..]) ; //!!!
            CustomTuple<string, string, string> line1 = new (name1,address,town);

            string name2 = secondLine[0] ;
            int beersToDrink = int.Parse(secondLine[1]) ;
            bool drinkOrNot = secondLine[2] == "drunk" ;
            CustomTuple<string, int, bool> line2 = new (name2, beersToDrink,drinkOrNot);

            string name3 = thirdLine[0];
            double accountBalance = double.Parse(thirdLine[1]);
            string bankName = thirdLine[2] ;
            CustomTuple<string, double,string> line3 = new (name3, accountBalance,bankName);

            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);

            }
        }
    }