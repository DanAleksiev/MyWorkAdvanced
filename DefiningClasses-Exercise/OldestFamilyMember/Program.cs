
using OldestFamilyMember;

namespace DefiningClasses
    {
    public class StartUp
        {
        public static void Main(string[] args)
            {
            Family family= new Family();
            int numberOfMembers = int.Parse(Console.ReadLine());

            for (int member = 0; member < numberOfMembers; member++)
                {
                string[] nameAge = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = nameAge[0];
                int age = int.Parse(nameAge[1]);

                Person person = new (name ,age);
                family.AddMember(person);
                }
            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
            }
        }
    }
