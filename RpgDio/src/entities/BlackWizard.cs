using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgDio.src.entities
{
    internal class BlackWizard : Hero
    {
        public BlackWizard(string name, int level, string heroType, int health, int mana) :
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
            return $"{Name} atacou o oponente com sua magia negra";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 7)
            {
                return $"{Name} ganhou um bonus forte de {Bonus} na conjuração da habilidade";
            }
            else
            {
                return $"{Name} ganhou um bonus fraco de {Bonus} na conjuração da habilidade";
            }
        }
    }
}
