using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animal
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight,double wingSize) : base(name, weight)
        {
            this.Wingsize = wingSize;
        }
        public double  Wingsize { get; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString()).Append($" { this.Wingsize}, { this.Weight}, { this.FoodEaten}]");
            return sb.ToString().TrimEnd();
        }
    }
}
