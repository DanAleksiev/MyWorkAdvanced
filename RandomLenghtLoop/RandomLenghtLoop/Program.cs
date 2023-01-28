namespace RandomLenghtLoop
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Lets see the avarage number of tryes to find 2 equal resoults of infinite sided dice.");
            Console.WriteLine("How many sides the dice have (i don't advise more thean 1000):");
            int limit=int.Parse (Console.ReadLine());
            Console.WriteLine("How many cykles do you want ?");
            int cikles = int.Parse(Console.ReadLine());
            
            int target = 0;
            int randoNumber = 0;
            long avarage = 0;
            int loops = 0;
            long totalNumOfTryes = 0; 
            Random random = new Random();

            for (int i = 0; i < cikles; i++)
                {
                loops = 1;
                target = random.Next(0, limit);
                randoNumber = random.Next(0, limit);
                while (target != randoNumber)
                    {
                    Console.WriteLine($"\\{loops}/ <{target}> [{randoNumber}]  - current cikle is ({i}) out of {cikles}");
                    randoNumber = random.Next(0, limit);
                    target = random.Next(0, limit);

                    loops++;
                    }

                Console.WriteLine(loops);
                totalNumOfTryes += loops;
                avarage += loops;
                }
            avarage /= cikles;

            Console.WriteLine($"\\{loops}/ <{target}> [{randoNumber}] ");
            Console.WriteLine($"Congrats it took you {loops}times running the cikle to get two same random numbers");
            Console.WriteLine($"the avarage chance is {avarage} out of {cikles} cikles and the total number of tries was {totalNumOfTryes}");
            }
        }
    }