using static PokemonTrainer.Trainers;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainers> trainers = new Dictionary<string, Trainers>();
            List<Pokemon> pokemonList = new List<Pokemon>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Tournament")
                {
                    break;
                }
                string[] parts = line.Split();
                string trainerName = parts[0];
                string pokemonName = parts[1];
                string pokemonElement = parts[2];
                int pokemonHealth = int.Parse(parts[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainers(trainerName);
                }

                Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                trainers[trainerName].AddPokemon(newPokemon);
                pokemonList.Add(newPokemon);
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                foreach (var trainer in trainers.Values)
                {
                    if (trainer.PokemonCollection.Any(pokemon => pokemon.Element == command))
                    {
                        trainer.IncreaseBadges();
                    }
                    else
                    {
                        trainer.DecreasePokemonHealth(command);
                    }
                }
            }

            var sortedTrainers = trainers.Values.OrderByDescending(trainer => trainer.Badges)
                                               .ThenBy(trainer => trainer.Name);

            foreach (var trainer in sortedTrainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.PokemonCollection.Count}");
            }
        }
    }
    public class Trainers
    {
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> PokemonCollection { get; }
        public Trainers(string name)
        {
            Name = name;
            Badges = 0;
            PokemonCollection = new List<Pokemon>();
        }
        public void AddPokemon(Pokemon p)
        {
            PokemonCollection.Add(p);
        }
        public void IncreaseBadges()
        {
            Badges++;
        }
        public void DecreasePokemonHealth(string element)
        {
            foreach (var pokemon in PokemonCollection.ToList())
            {
                if (pokemon.Element == element)
                {
                    return;
                }
            }

            foreach (var pokemon in PokemonCollection.ToList())
            {
                pokemon.Health -= 10;
                if (pokemon.Health <= 0)
                {
                    PokemonCollection.Remove(pokemon);
                }
            }
        }
        public class Pokemon
        {
            public string Name { get; set; }
            public string Element { get; set; }
            public int Health { get; set; }

            public Pokemon(string name, string element, int health)
            {
                Name = name;
                Element = element;
                Health = health;
            }
        }
    }
}