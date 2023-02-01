namespace DefiningClasses
    {
    public class StartUp
        {
        public static void Main(string[] args)
            {
            List<Person> family= new ();
            int numberOfMembers = int.Parse(Console.ReadLine());

            for (int member = 0; member < numberOfMembers; member++)
                {
                string[] nameAge = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = nameAge[0];
                int age = int.Parse(nameAge[1]);

                Person person = new (name ,age);
                family.Add(person);
                }
            foreach (Person person in family.Where(p => p.Age >30).OrderBy(p =>p.Name))
                {
                Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
        }
    }
