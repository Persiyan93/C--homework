using AquaShop.Models.Decorations.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public abstract class Decoration : IDecoration
    {
        public Decoration(int comfort,decimal price)
        {
            this.Price = price;
            this.Comfort = comfort;

        }
        
        public int Comfort { get; }

        public decimal Price { get; }
    }
}
