using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Bus:Vehicle
       
    {
        public Bus(string fuelquantity,string consum,string tankCapasity)
        {
            this.TankCapacity = double.Parse(tankCapasity);
            this.FuelQuantity = double.Parse(fuelquantity);
            this.Fuelconsum = double.Parse(consum);
            
        }
        public void DrivewithPassenger(double distance)
        {
            if (FuelQuantity>=(Fuelconsum+1.4)*distance)
            {
                FuelQuantity = FuelQuantity - ((Fuelconsum + 1.4) * distance);
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }
    }
}
