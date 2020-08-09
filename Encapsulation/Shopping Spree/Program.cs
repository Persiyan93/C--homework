using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> people = new List<Person>();
                string[] peoples = Console.ReadLine().Split(";");
                for (int i = 0; i < peoples.Length; i++)
                {
                    string[] input = peoples[i].Split("=");
                    Person person = new Person(input[0], decimal.Parse(input[1]));
                    people.Add(person);

                }
                string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                List<Product> collectionOfProducts = new List<Product>();
                for (int i = 0; i < products.Length; i++)
                {
                    string[] input = products[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                    Product currentProduct = new Product(input[0], decimal.Parse(input[1]));
                    collectionOfProducts.Add(currentProduct);

                }
                string shoping;
                Dictionary<string, string> allProducts = new Dictionary<string, string>();
                while ((shoping = Console.ReadLine()) != "END")
                {
                    string[] shopingInfo = shoping.Split(" ");
                    string nameOfperson = shopingInfo[0];
                    string product = shopingInfo[1];
                    Person currentperson = new Person();
                    currentperson = people.Where(x => x.Name == nameOfperson).FirstOrDefault();
                    Product currentproduct = new Product();
                    currentproduct = collectionOfProducts.Where(x => x.Name == product).FirstOrDefault();
                    currentperson.Buy(currentproduct);

                }
                foreach (var item in people)
                {
                    bool check = false;
                    if (item.Bagofproducts.Count != 0)
                    {
                        check = true;
                        Console.Write($"{item.Name} -");


                        for (int i = 0; i < item.Bagofproducts.Count; i++)
                        {
                            if (i != item.Bagofproducts.Count - 1)
                            {
                                Console.Write($" {item.Bagofproducts[i].Name},");
                            }
                            else
                            {
                                Console.Write($" {item.Bagofproducts[i].Name}");
                            }
                        }

                        Console.WriteLine();
                    }
                    if (!check)
                    {
                        Console.WriteLine("{0} - Nothing bought", item.Name);
                    }
                }
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae.Message);
            }
           


        }
    }
}
