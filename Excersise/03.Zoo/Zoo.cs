using System.Collections.Generic;
using System.Linq;

namespace Zoo
    {
    public class Zoo
        {
        private List<Animal> animals;

        public Zoo(string name, int capacity)
            {
            Name = name;
            Capacity = capacity;
            animals = new List<Animal>();
            }

        public List<Animal> Animals { get { return animals; } set { animals = value; } }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public string AddAnimal(Animal animal)
            {
            if (animal == null) return "Invalid animal species.";
            if (animal.Diet != "herbivore" && animal.Diet != "carnivore") return "Invalid animal diet.";
            if (Capacity == 0) return "The zoo is full.";
            animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
            }
        public int RemoveAnimals(string species)
            {
            return animals.RemoveAll(x => x.Species == species);
            }
        public List<Animal> GetAnimalsByDiet(string diet)
            {
            return animals.FindAll(x=>x.Diet== diet);
            }
        public Animal GetAnimalByWeight(double weight)
            {
            return animals.FirstOrDefault(x=>x.Weight== weight);
            }
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
            {
            int count = animals.Count(x => x.Length >= minimumLength &&  x.Length <= maximumLength);
            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
            }
        }
    }
