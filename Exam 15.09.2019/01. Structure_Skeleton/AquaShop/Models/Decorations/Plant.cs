using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Plant : Decoration
    {
        private const int DEFAULT_COMFORT = 5;
        private const decimal DEFAULT_PRICE = 10m;
        public Plant() : base(DEFAULT_COMFORT, DEFAULT_PRICE)
        {
        }
    }
}
