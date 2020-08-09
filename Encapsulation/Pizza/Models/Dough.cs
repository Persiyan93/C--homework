using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pizzaaa.Models
{
    class Dough
    {
        private const Double BASE_CALORIE_PER_GRAM = 2;
        private string flourtype;

        private string Flourtype
        {
            get { return flourtype; }
            set
            {
                if (value != "white" && value != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourtype = value;
            }
        }
        private string bakingtechnique;

        private string Bakingtechnique
        {
            get { return bakingtechnique; }
            set
            {
                if (value != "crispy" && value != "chewy" && value != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingtechnique = value;
            }
        }
        private double weight;

        private double Weight
        {
            get { return weight; }
            set
            {
                if (value > 200 || value < 1)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }
        private double calories;

        public double Calories
        {
            get { return calories; }

        }

        private void CalculateCaloriesPerGram()
        {
            double bakingmodifiers = 0;
            double flourmodifiers = 0;
            switch (Bakingtechnique)
            {
                case "crispy":
                    bakingmodifiers = 0.9;
                    break;
                case "chewy":
                    bakingmodifiers = 1.1;
                    break;
                case "homemade":
                    bakingmodifiers = 1.0;
                    break;
                default:
                    break;
            }
            switch (Flourtype)
            {
                case "white":
                    flourmodifiers = 1.5;
                    break;
                case "wholegrain":
                    flourmodifiers = 1.0;
                    break;
                default:
                    break;

            }
            this.calories = flourmodifiers * bakingmodifiers * BASE_CALORIE_PER_GRAM*Weight;
        }
        public Dough(string flourtype, string bakingTechnique, string grams)
        {
            this.Flourtype = flourtype;
            this.Bakingtechnique = bakingTechnique;
            this.Weight = double.Parse(grams);
            CalculateCaloriesPerGram();
        }
        




    }
}
