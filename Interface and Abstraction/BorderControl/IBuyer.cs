using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    interface IBuyer
        
    {
        public string Name { get; set; }
        public int Food { get; set; }
        public  void BuyFood();
    }
}
        