using System;
using System.Collections.Generic;
using System.Text;

namespace _9.PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }

        public int BadgesCount { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name)
        {
            this.Name = name;
            this.BadgesCount = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public override string ToString()
        {
            return $"{this.Name} {this.BadgesCount} {this.Pokemons.Count}";
        }
    }
}
