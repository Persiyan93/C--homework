using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Exception;
using WildFarm.Models.Animal.Contracts;
using WildFarm.Models.Food.Contracts;

namespace WildFarm.Models.Animal
{
    public abstract class Animal : IAnimal

    {
        private const string UneatableFoodMessage = " {0} does not eat {1}!";
    
        public Animal(string name,double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string Name { get; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }
        public abstract double WeightMultiplier { get; }
        public abstract ICollection<Type> PrefferFoods { get; }

        public void Feed(IFood food)
        {
            if (!this.PrefferFoods.Contains(food.GetType()))
            {
                throw new UnEatableFoodException(string.Format(UneatableFoodMessage, this.GetType().Name, food.GetType().Name));
            }
            this.Weight += this.WeightMultiplier * food.Quantity;
            this.FoodEaten += food.Quantity;
        }

        public abstract string ProduceSound();
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name},";
        }

    }
}
