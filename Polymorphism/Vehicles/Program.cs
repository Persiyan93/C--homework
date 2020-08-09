using System;
using System.Transactions;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carTokens = Console.ReadLine().Split();
            double fuelConsum = double.Parse(carTokens[2]);
            double fuelQuantity = double.Parse(carTokens[1]);
            Car car = new Car(carTokens[1], carTokens[2],carTokens[3]);
            string[] truckTokens = Console.ReadLine().Split();
            Truck truck = new Truck(truckTokens[1], truckTokens[2],truckTokens[3]);
            string[] busTokens = Console.ReadLine().Split();
            Bus bus = new Bus(busTokens[1], busTokens[2], busTokens[3]);
            int numberOfComands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfComands; i++)
            {
                string[] comand = Console.ReadLine().Split();
                if (comand[0] == "Drive")
                {
                    double distance = double.Parse(comand[2]);
                    if (comand[1] == "Car")
                    {
                        car.Drive(distance);
                    }
                    else if (comand[1] == "Truck")
                    {
                        truck.Drive(distance);
                    }
                    else if (comand[1] == "Bus")
                    {
                        bus.DrivewithPassenger(distance);
                    }

                }
                else if (comand[0] == "Refuel")
                {
                    double quantity = double.Parse(comand[2]);
                    if (comand[1] == "Car")
                    {
                        car.Refuel(quantity);
                    }
                    else if (comand[1] == "Truck")
                    {
                        truck.Refuel(quantity);
                    }
                    else if (comand[1] == "Bus")
                    {
                        bus.Refuel(quantity);
                    }
                }
                else if (comand[0] == "DriveEmpty") 
                {
                    bus.DrivewithPassenger(double.Parse(comand[2]));
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
         }
    }
}
