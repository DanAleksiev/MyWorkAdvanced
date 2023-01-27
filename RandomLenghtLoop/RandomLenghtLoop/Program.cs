namespace RandomLenghtLoop
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Random random = new Random();
            int target = 0;
            int randoNumber = 0;
            long avarage = 0;
            int loops = 0;
            int cikles = 100000;
            for (int i = 0; i < cikles; i++)
                {
                loops = 1;
                target = random.Next(0, 1000);
                randoNumber = random.Next(0, 1000);
                while (target != randoNumber)
                    {
                    Console.WriteLine($"\\{loops}/ <{target}> [{randoNumber}] ");
                    randoNumber = random.Next(0, 1000);
                    target = random.Next(0, 1000);

                    loops++;
                    }

                Console.WriteLine(loops);
                avarage += loops;
                }
            avarage /= cikles;
            Console.WriteLine($"\\{loops}/ <{target}> [{randoNumber}] ");
            Console.WriteLine($"Congrats it took you {loops}times running the cikle to get two same random numbers");
            Console.WriteLine($"the avarage chance is {avarage} out of {cikles} cikles");
            }
        }
    }