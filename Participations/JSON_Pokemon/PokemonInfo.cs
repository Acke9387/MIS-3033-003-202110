using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Pokemon
{
    public class PokemonInfo
    {

        public int height { get; set; }

        public string name { get; set; }

        public double weight { get; set; }

        public Sprite sprites { get; set; }


    }

    public class Sprite
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
    }
}
