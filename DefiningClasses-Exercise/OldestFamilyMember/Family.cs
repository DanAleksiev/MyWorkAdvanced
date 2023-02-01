using DefiningClasses;

namespace OldestFamilyMember
    {
    public class Family
        {
        private List<Person> people;
        public Family()
            {
            people = new List<Person>();
            }

        public void AddMember(Person name)
            {
            this.people.Add(name);
            }
        public Person GetOldestMember()
            {

            return this.people.MaxBy(people=> people.Age);
            }
        }
    }
