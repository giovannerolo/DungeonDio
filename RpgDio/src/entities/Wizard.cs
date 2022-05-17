using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgDio.src.entities
{
    internal class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType, int health, int mana) : 
            base(name, level, heroType, health, mana)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            Health = health;
            Mana = mana;
        }

        public override string Attack()
        {
            return $"{Name} lançou uma magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return $"{Name} lançou uma magia super efetiva com bonus de {Bonus}";
            }
            else
            {
                return $"{Name} lançou uma magia com força fraca de {Bonus}";
            }
        }


    }
}
