using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arus_namespace;

namespace _5_Jogo_de_RPG.src.Entities
{
    public class Wizzard : Hero
    {

        public Wizzard (string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        public Wizzard()
        {

        }
        public override string Attack()
        {
            return this.Name + "Atacou com sua espada";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + "Lançou Magia com bonus de ataque de " + Bonus;
            } else {
                return this.Name + "Lançou uma magia com combo força fraca";
            }
        }
    }
}