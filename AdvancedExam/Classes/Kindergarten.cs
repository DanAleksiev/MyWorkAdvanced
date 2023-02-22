using System.Text;

namespace SoftUniKindergarten
    {
    public class Kindergarten
        {
        public Kindergarten(string name, int capacity)
            {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
            }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }
        public int ChildrenCount { get => Registry.Count; }
        public bool AddChild(Child child)
            {
            if (Capacity == Registry.Count)
                {
                return false;
                }
            Registry.Add(child);
            return true;
            }
        public bool RemoveChild(string childFullName)
            {
            string[] childNames = childFullName.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string name = childNames[0];
            string surname = childNames[1];
            foreach (var child in Registry)
                {
                if (child.FirstName == name && child.LastName == surname)
                    {
                    Registry.Remove(child);
                    return true;
                    }
                }
            return false;
            }
        public string GetChild(string childFullName)
            {
            string[] childNames = childFullName.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string name = childNames[0];
            string surname = childNames[1];
            Child child = Registry.FirstOrDefault(x => x.FirstName == name && x.LastName == surname);
            return child.ToString();
            }

        public string RegistryReport()
            {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");
            foreach (var child in Registry.OrderByDescending(x=>x.Age).ThenBy(x=>x.LastName).ThenBy(x => x.FirstName))
                {
                sb.AppendLine(child.ToString());
                }
            return sb.ToString().Trim();
            }
        }
    }
