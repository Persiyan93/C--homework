using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models.Contracts
{
    public interface IHero
    {
        public string Name { get; }
        public int Power { get; }
        public string CastAbility();
    }
}
