using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Food;
using WildFarm.Models.Food.Contracts;

namespace WildFarm.Models.Animal
{
    public class Cat : Feline
    {
        private const double WEIGHT_MULTIPLIER = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplier => WEIGHT_MULTIPLIER;

        public override ICollection<Type> PrefferFoods => new List<Type>() {typeof(Vegetable),typeof(Meat) };

        public override string ProduceSound()
        {
            return "Meow";
        }
        
    }
}
