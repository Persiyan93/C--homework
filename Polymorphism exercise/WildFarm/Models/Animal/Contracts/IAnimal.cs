using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Food.Contracts;

namespace WildFarm.Models.Animal.Contracts
{
    interface IAnimal
    {
        public string Name { get;  }
        public double Weight { get;  }
        public int FoodEaten { get;  }
        public abstract string ProduceSound();
        void Feed(IFood food);
    }
}
