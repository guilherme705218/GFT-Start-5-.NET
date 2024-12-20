using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arus_namespace
{
    public abstract class Hero
    {
        public string? Name;
        public int? Level;
        public string? HeroType;

        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public Hero()
        {

        }

        public override string ToString()
        {
            return this.Name;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }

    }
}