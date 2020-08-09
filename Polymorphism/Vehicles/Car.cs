using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Car : Vehicle
    {
        public Car(string fuelquantity, string consum, string tankcapacity)
        {

            this.TankCapacity = double.Parse(tankcapacity);
            this.FuelQuantity = double.Parse(fuelquantity);
            this.Fuelconsum = double.Parse(consum) + 0.9;


        }
    }
}
