using System;
using System.Collections.Generic;

namespace Car
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {


                string[] currentEngine = Console.ReadLine().Split(" ");
                var model = currentEngine[0];
                double power = double.Parse(currentEngine[1]);
                Engine engine = new Engine(model, power);
                if (currentEngine.Length == 3)
                {
                    double displacement;
                    if (double.TryParse(currentEngine[2], out displacement))
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        engine.Efficiency = currentEngine[2];
                    }
                    
                }
                else if (currentEngine.Length == 4)
                {
                    double displacement = double.Parse(currentEngine[2]);
                    engine.Displacement = displacement;
                    engine.Efficiency = currentEngine[3];
                }
                engine.ToString();
                engines.Add(engine.Model, engine);
            }
           
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < count; i++)
            {
                string[] currentCar = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = currentCar[0];
                Engine engine = engines[currentCar[1]];
                Car car = new Car(model, engine);
                if (currentCar.Length==3)
                {
                    double weight;
                    if (double.TryParse(currentCar[2],out weight))
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = currentCar[2];
                    }
                }
                else if(currentCar.Length==4)
                {
                    double weight = double.Parse(currentCar[2]);
                    string color = currentCar[3];
                    car.Weight = weight;
                    car.Color = color;
                }
               
                
                cars.Add(car.Model, car);
            }
            foreach (var item in cars)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("  {0}", item.Value.Engine.Model);
                Console.WriteLine("    Power: {0}", engines[item.Value.Engine.Model].Power);
                if (item.Value.Engine.Displacement==0)
                {
                    Console.WriteLine("    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine("    Displacement: {0}", item.Value.Engine.Displacement);
                }
                Console.WriteLine("     Efficiency: {0}", item.Value.Engine.Efficiency);
                if (item.Value.Weight==0)
                {
                    Console.WriteLine("  Weight: n/a");

                }
                else
                {
                    Console.WriteLine("  Weight: {0}", item.Value.Weight);
                }
                Console.WriteLine("  Color: {0}", item.Value.Color);
                

                
            }
            
        }
    }
}
