using System;
using System.Collections.Generic;
using System.Text;

namespace Speed
{
    public class Car
    {
		public Car(string model,string fuelAmount,string fuelConsumptionFor1km)
		{
			this.Model = model;
			this.FullAmount = double.Parse(fuelAmount);
			this.FuelConsumptionPerKilometer = double.Parse(fuelConsumptionFor1km);
		}
		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private double fuelamount;

		public double FullAmount
		{
			get { return fuelamount; }
			set { fuelamount = value; }
		}
		private double	 fuelconsumptionPerKilometer;

		public double FuelConsumptionPerKilometer
		{
			get { return fuelconsumptionPerKilometer; }
			set { fuelconsumptionPerKilometer = value; }
		}
		private double travelleddistance;

		public double TraevelledDistance
		{
			get { return travelleddistance; }
			set { travelleddistance = value; }
		}

		public void Drive(double distance)
		{
			if (FullAmount/FuelConsumptionPerKilometer>=distance)
			{
				this.FullAmount =FullAmount-( distance *FuelConsumptionPerKilometer);
				this.TraevelledDistance =TraevelledDistance+ distance;
			}
			else
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}
		}

	}
}
