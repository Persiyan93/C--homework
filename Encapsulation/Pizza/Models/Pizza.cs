using System;
using System.Collections.Generic;
using System.Text;

namespace  Pizzaaa.Models
{
    class Pizza
    {
        private string name;

        public string Name
        {
            get { return name; }
           private  set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }
        private Dough dough;
        private List<Topping> toppings;

        public IReadOnlyCollection<Topping> Toppings
        {
            get { return toppings; }
            
        }
        private double calories;
        public Pizza(string name)
        {
            this.Name = name;
            toppings = new List<Topping>();

        }
        public void AddDough(string flourType,string bakingTehnique,string weight)
        {
            dough = new Dough(flourType, bakingTehnique, weight);
        }
        public void AddTopping(Topping topping)
        {
            if (toppings.Count==9)
            {
                throw new InvalidOperationException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }
        public void Pizzacalories()
        {
            
            double caloriesFromTopings = 0;
            foreach (var item in toppings)
            {
                caloriesFromTopings += item.Calories;
            }
            calories =
                caloriesFromTopings + dough.Calories;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1:F2} Calories.", Name, calories);
        }



    }
}
