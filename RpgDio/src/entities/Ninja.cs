﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgDio.src.entities
{
    internal class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType, int health, int mana) :
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
            return $"{Name} atacou o oponente com sua arma ninja";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 9)
            {
                return $"{Name} acertou um crítico super efetivo, bonus de {Bonus} no ataque";
            }
            else
            {
                return $"{Name} acertou um crítico fraco de {Bonus} no ataque";
            }
        }
    }
}
