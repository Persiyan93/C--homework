using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string name;
        private int bulletCounts;
        public Gun(string name, int bulletCount)
        {
            this.Name = name;
            this.BulletsCount = bulletCount;
        }



        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    new ArgumentException(ExceptionMessages.InvalidGunName);
                }
                else { name = value; }
            }
        }

        public int BulletsCount
        {
            get => bulletCounts;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGunBulletsCount);
                }
                else
                {
                    bulletCounts = value;
                }
            }
        }

        public abstract int Fire();

    }
}
