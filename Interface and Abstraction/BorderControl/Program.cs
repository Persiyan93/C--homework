using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();
            int numberOfMembers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfMembers; i++)
            {
                string[] memberTokens = Console.ReadLine().Split();
                if (memberTokens.Length==4)
                {
                    Citizen citizen = new Citizen(memberTokens[0], memberTokens[1], memberTokens[2], memberTokens[3]);
                    buyers.Add(citizen);

                }
                else if (memberTokens.Length==3)
                {
                    Rebel rebel = new Rebel(memberTokens[0], memberTokens[1], memberTokens[2]);
                    buyers.Add(rebel);
                }

            }
            string operation;
            while ((operation=Console.ReadLine())!="End")
            {
               
                if (buyers.FirstOrDefault(x=>x.Name==operation) !=null)
                {
                    buyers.First(x => x.Name == operation).BuyFood();
                }
            }
            Console.WriteLine(buyers.Sum(x => x.Food));
        }
    }
}
