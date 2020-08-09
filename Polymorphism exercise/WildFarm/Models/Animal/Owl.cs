using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Food;
using WildFarm.Models.Food.Contracts;

namespace WildFarm.Models.Animal
{
    public class Owl : Bird
    {
        private const double WEIGHT_MULTIPLIER= 0.25;
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier => WEIGHT_MULTIPLIER;

        public override ICollection<Type> PrefferFoods => new List<Type>() { typeof(Meat)};

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
