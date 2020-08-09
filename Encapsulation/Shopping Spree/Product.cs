using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    public class Product
    {

        private decimal price;
        private string name;

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
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                price = value;
            }
        }
        public Product(string name,decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Product() { }

    }
}
