using Raiding.Exceptionn;
using Raiding.Factories;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raiding.Core
{
   public class Engine:IEngine
    {
        private ICollection<BaseHero> heroes;
        public Engine()
        {
            HeroFactory heroFactory = new HeroFactory();
            heroes = new List<BaseHero>();
        }

        public void Run()
        {
            int heroesCont = int.Parse(Console.ReadLine());
            while (heroesCont!=heroes.Count)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();
               
                BaseHero hero = null;
                try
                {
                    hero=HeroFactory.CreateHero(heroName, heroType);
                    heroes.Add(hero);

                }
                catch (IvalidWariorException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                




            }
            int bossPower = int.Parse(Console.ReadLine());
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }
            int powerSum = heroes.Sum(x => x.Power);
            if (powerSum>=bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
