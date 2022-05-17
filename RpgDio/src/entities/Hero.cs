using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgDio.src.entities
{
    internal class Hero
    {
        public Hero(string name, int level, string heroType, int health, int mana)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            Health = health;
            Mana = mana;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        public override string ToString()
        {
            return "Nome: " + Name + ", Level: " + Level + ", Classe: " +
                HeroType + ", Vida: " + Health + ", Mana: " + Mana;
        }

        public virtual string Attack()
        {
            return $"{Name} atacou com a sua espada";
        }
    }
}
