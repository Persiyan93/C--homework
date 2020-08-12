using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public class Rifle : Gun
    {
        public Rifle(string name, int bulletCount) : base(name, bulletCount)
        {
        }

        public override int Fire()
        {
            if (BulletsCount-10<0)
            {
                return 0;
            }
            else
            {
                BulletsCount -= 10;
                return 10;
            }
        }
    }
}
