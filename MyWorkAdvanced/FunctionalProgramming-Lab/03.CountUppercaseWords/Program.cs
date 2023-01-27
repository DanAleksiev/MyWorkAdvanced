namespace _03.CountUppercaseWords
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Predicate<string> fillterByUpper = s => s[0] == char.ToUpper(s[0]) && char.IsLetter(s[0]);

            string[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Where(s => fillterByUpper(s))
                .ToArray();

            foreach (string s in input)
                {
                Console.WriteLine(s);
                }
            }
        }
    }