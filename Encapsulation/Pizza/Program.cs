using Pizzaaa.Models;
using System;
using System.Globalization;

namespace Pizzaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string comand;
                string[] nameOfpizza = Console.ReadLine().Split(" ");
                Pizza pizza = new Pizza(nameOfpizza[1]);
                string[] doughTokens = Console.ReadLine().Split(" ");
                
                pizza.AddDough(doughTokens[1], doughTokens[2], doughTokens[3].ToLower());



                while ((comand=Console.ReadLine())!="END")
                {
                    string[] topisngsTokens = comand.Split(" ");
                    Topping topping = new Topping(topisngsTokens[1].ToLower(), topisngsTokens[2].ToLower());
                    pizza.AddTopping(topping);
                }
                pizza.Pizzacalories();
                Console.WriteLine(pizza);
            }

            catch (Exception ae)
            {

                Console.WriteLine(ae.Message);
            }

        }
    }
}
