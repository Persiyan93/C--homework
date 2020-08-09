using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaaa.Models
{
    class Topping
    {
        private double weight;
        private double Weight
        {
            get { return weight; }
            set
            {
                if (value > 50 || value < 1)
                {
                    throw new ArgumentException(String.Format("{0} weight should be in the range [1..50].", Type));
                }
                weight = value;
            }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set
            {
                if (value == "Meat" || value == "Veggies" || value == "Cheese" || value == "Sauce")
                {
                    type = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("Cannot place {0} on top of your pizza.", value));
                }

            }
        }
        public double Calories { get; set; }
        public Topping(string type,string weight)
        {
            this.Type = type;
            this.Weight = double.Parse(weight);
            CalculateCaloriesPerGram();
        }

        private void CalculateCaloriesPerGram()
        {
            double typeModifier = 0;
            switch (Type)
            {
                case "Meat":
                    typeModifier = 1.2;
                    break;
                case "Veggies":
                    typeModifier = 0.8;
                    break;
                case "Cheese":
                    typeModifier = 1.1;
                    break;
                case "Sauce":
                    typeModifier = 0.9;
                    break;

                default:
                    break;
            }
            Calories= 2 * typeModifier*Weight;
        }

    }
}
