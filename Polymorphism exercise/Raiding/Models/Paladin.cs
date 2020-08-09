﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    class Paladin : BaseHero
    {
        private const int POWER = 100;

        public Paladin(string name) : base(name)
        {
        }

        public override int Power => POWER;

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
