using System;
using System.Collections.Generic;

namespace Speed
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            int countOfRacer = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfRacer; i++)
            {
                string[] itput = Console.ReadLine().Split(" ");
                Car currentCar = new Car(itput[0], itput[1], itput[2]);
                cars.Add(currentCar.Model, currentCar);
            }
            string input2;
            while ((input2=Console.ReadLine())!="End")
            {

                string[] comand = input2.Split(" ");
                cars[comand[1]].Drive(double.Parse(comand[2]));
                
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Value.Model} {item.Value.FullAmount:F2} {item.Value.TraevelledDistance}");
            }
            
        }
    }
}
