﻿using P03Raiding.Models;

namespace P03Raiding.Factories
{
    public class WarriorFactory : HeroFactory
    {
        private string name;

        public WarriorFactory(string name)
        {
            this.name = name;
        }

        public override BaseHero CreateHero()
        {
            return new Warrior(name);
        }
    }
}
