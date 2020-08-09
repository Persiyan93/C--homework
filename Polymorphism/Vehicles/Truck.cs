using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Truck:Vehicle
    {
        public Truck(string fuelquantity,string consum,string tankcapacity)
        {
            this.TankCapacity = double.Parse(tankcapacity);
            this.FuelQuantity = double.Parse(fuelquantity);
            this.Fuelconsum = double.Parse(consum) + 1.6;
           
        }
        public override void Refuel(double quantity)
        {
            if (quantity > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {quantity} fuel in the tank");
            }
            else if (quantity <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
                FuelQuantity += quantity*0.95;
        }
    }
}
