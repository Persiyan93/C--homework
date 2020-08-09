using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    public class Person
    {
        private string name;
        private   List<Product> bagofproducts;

        public  List<Product> Bagofproducts
        {
            get { return bagofproducts; }
            set { bagofproducts = value; }
        }

        private decimal money;
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                {
                    name = value;
                }
            }


        }

        public decimal Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        public Person()
        {
            this.bagofproducts = new List<Product>();
        }
        public Person(string name, decimal money)
        {
            this.name = name;
            this.Money = money;
            this.bagofproducts = new List<Product>();
        }
        public void Buy(Product product)
        {
            if (product.Price > this.Money)
            {
                Console.WriteLine($"{this.name} can't afford {product.Name}");
            }
            else
            {
                bagofproducts.Add(product);
                this.Money = Money - product.Price;
                Console.WriteLine($"{this.name} bought {product.Name}");
            }
        }


    }
}
