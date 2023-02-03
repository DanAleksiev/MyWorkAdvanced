namespace PokemonTrainer
    {
    public class Trainer
        {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer()
            {
            numberOfBadges= 0;
            List<Pokemon> pokemons = new List<Pokemon>();
            }
        public Trainer (string name, int numberOfBadges) : this()
            {
            Name = name;
            NumberOfBadges = numberOfBadges;
            }
        public Trainer(string name, int numberOfBadges, List<Pokemon> pokemons):this( name,  numberOfBadges)
            {
            Name = name;
            NumberOfBadges = numberOfBadges;
            Pokemons = pokemons;
            }

        public string Name { get { return name; } set { name = value; } }
        public int NumberOfBadges { get { return numberOfBadges; } set { numberOfBadges = value; } }
        public List<Pokemon> Pokemons { get { return pokemons; } set { pokemons = value; } }

        }
    }
