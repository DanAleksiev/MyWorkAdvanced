using PokemonTrainer;

internal class Program
    {
    private static void Main(string[] args)
        {
        string input;
            List<Trainer> trainers = new();
            while ((input = Console.ReadLine()) != "Tournament")
                {
                string[] splitter = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Trainer trainer = new Trainer();
                trainer.Name = splitter[0];
                Pokemon pokemon = new Pokemon();
                pokemon.Name = splitter[1];
                pokemon.Element = splitter[2];
                pokemon.Health = int.Parse(splitter[3]);

                if (trainers.Count > 0)
                    {
                    bool exist = false;
                    foreach (var train in trainers)
                        {
                        if (train.Name == trainer.Name)
                            {
                            train.Pokemons.Add(pokemon);
                            exist = true;
                            break;
                            }
                        }
                    if (!exist)
                        {
                        trainer.Pokemons = new List<Pokemon>();
                        trainer.Pokemons.Add(pokemon);
                        trainers.Add(trainer);
                        }
                    }
                else
                    {
                    trainer.Pokemons = new List<Pokemon>();
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                    }
                }

            while ((input = Console.ReadLine()) != "End")
                {
                foreach (var train in trainers)
                    {
                    bool doesItHave = false;
                    foreach (var pokemon in train.Pokemons)
                        {
                        if (pokemon.Element == input)
                            {
                            doesItHave = true;
                            train.NumberOfBadges++;
                            }
                        }
                    if (!doesItHave)
                        {
                        for (int i = 0; i < train.Pokemons.Count; i++)
                            {
                            List<Pokemon> pokemon = train.Pokemons;
                            pokemon[i].Health -= 10;
                            if (pokemon[i].Health < 0)
                                {
                                train.Pokemons.Remove(pokemon[i]);
                                }
                            train.Pokemons = pokemon;
                            }
                        }
                    }
                }

            foreach (var train in trainers.OrderByDescending(t => t.NumberOfBadges))
                {
                Console.WriteLine($"{train.Name} {train.NumberOfBadges} {train.Pokemons.Count}");
                }
            }
    }