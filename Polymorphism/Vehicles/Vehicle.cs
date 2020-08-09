using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double tankCapacity;
        private double fuelquantity;

        public double TankCapacity
        {
            get { return tankCapacity ; }
            protected set
            {

                tankCapacity = value;
            }
        }

        public double FuelQuantity
        {
            get
            {
                return fuelquantity;
            }
            set
            {
                if (value<=TankCapacity)
                {
                    this.fuelquantity = value;
                }
                else
                {
                    this.fuelquantity = 0;
                }

            }
        }
        public double Fuelconsum { get; set; }
        public virtual void Refuel(double quantity)
        {
            if (quantity>TankCapacity)
            {
                Console.WriteLine($"Cannot fit {quantity} fuel in the tank");
            }
            else if (quantity<=0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else 
            FuelQuantity += quantity;
        }
        public void Drive(double distance)
        {
            if (FuelQuantity >= Fuelconsum * distance)
            {
                FuelQuantity -= Fuelconsum * distance;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }
        public override string ToString()
        {
            return string.Format($"{this.GetType().Name}: {Math.Round(this.FuelQuantity, 2):F2}");
        }
    }

}
