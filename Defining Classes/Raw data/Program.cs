using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Raw   
{
   public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                int weight = int.Parse(input[3]);
                string type = input[4];
                double tirepresuer1 = double.Parse(input[5]);
                int tireage1 = int.Parse(input[6]);
                double tirepresuer2 = double.Parse(input[7]);
                int tireage2 = int.Parse(input[8]);
                double tirepresuer3 = double.Parse(input[9]);
                int tireage3 = int.Parse(input[10]);
                double tirepresuer4 = double.Parse(input[11]);
                int tireage4 = int.Parse(input[12]);
                Car car = new Car(model, speed, power, weight, type, tirepresuer1, tireage1, tirepresuer2, tireage2,
                    tirepresuer3, tireage3, tirepresuer4, tireage4);
                cars.Add(car);
            }
            string input1 = Console.ReadLine();
            Func<Tire, bool> tire = x => x.TirePresure > 1;
            Func<Car, bool> mainfunc = x=> 
            {
                foreach (var item in x.Tires)
                {
                    if (item.TirePresure < 1 || x.Cargo.Cargotype.Equals("fragile")==false)
                    {
                        return false;
                    }

                }
                return true;
            } ;
            if (input1=="fragile")
            {
                cars = cars.Where(mainfunc).ToList();
                
            }
            else 
            {
                Func<Car, bool> func = x => x.Cargo.Cargotype.Equals("flamable") && x.Engine.Power > 250;


               

            cars = cars.Where(func).ToList();

            }
            foreach (var item in cars)
            {
                Console.WriteLine(item.Model);
            }
        }
    }
}
