﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count => this.data.Count;

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            this.data.Remove(this.data.FirstOrDefault(x => x.Name == name));
        }

        public Hero GetHeroWithHighestStrength()
        {
            return this.data.OrderByDescending(x => x.Item.Strength).FirstOrDefault();
        }

        public Hero GetHeroWithHighestAbility()
        {
            return this.data.OrderByDescending(x => x.Item.Ability).FirstOrDefault();
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            return this.data.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var hero in this.data)
            {
                sb.AppendLine(hero.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
