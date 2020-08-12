using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public class Pistol : Gun
    {
        public Pistol(string name, int bulletCount) : base(name, bulletCount)
        {
        }

        public override int Fire()
        {
            if (BulletsCount-1<0)
            {
                return 0;
            }
            else
            {
                BulletsCount -= 1;
                return 1;

            }
        }
    }
}
