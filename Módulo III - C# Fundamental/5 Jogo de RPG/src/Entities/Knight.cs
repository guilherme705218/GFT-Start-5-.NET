using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arus_namespace;

namespace _5_Jogo_de_RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight (string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
    }
}