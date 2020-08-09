using Raiding.Exceptionn;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Factories
{
    class HeroFactory
    {
        public static BaseHero CreateHero(string name,string type)
        {
            BaseHero hero = null;
            if (type=="Druid")
            {
                hero = new Druid(name);
            }
            else if (type=="Paladin")
            {
                hero = new Paladin(name);

            }
            else if (type=="Rogue")
            {
                hero = new Rogue(name);
            }
            else if (type=="Warrior")
            {
                hero = new Warrior(name);
            }
            else
            {
                throw new IvalidWariorException("Invalid hero!");
            }
            return hero;
            
        }
    }
}
