using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Transactions;

namespace Car
{
   public class Engine
    {
		public Engine()
		{

		}
		public Engine(string model,double power):this(model,power,0,"n/a")
		{
			
		} 
		public Engine(string model,double power,double displacement) : this(model, power,displacement,"n/a")
		{
			
		}
		public Engine(string model, double power,double displacement,string efficiency)
		{
			this.Model = model;
			this.Power = power;
			this.Displacement = displacement;
			this.Efficiency = efficiency;
		}
		private  string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private double power;

		public double Power
		{
			get { return power; }
			set { power = value; }
		}
		
		
		private double displacement;
		
		public  double Displacement
		{
			get { return displacement; }
			set { displacement = value; }
		}
		
		private	string efficiency;

		public string  Efficiency
		{
			get { return efficiency; }
			set { efficiency = value; }
		}

		public override string ToString()
		{
			return ($"{Model}:\n" + $"	Power: {Power}\n" + $"	Displacement: {Displacement}\n" + $"	Efficiency: {Efficiency}\n");
		}


	}
}
