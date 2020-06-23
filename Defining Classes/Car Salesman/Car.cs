using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Car
{
   public class Car
    {
		public Car(string model,Engine engine,double weight,string color)
		{
			this.Model = model;
			this.Engine = engine;
			this.Weight = weight;
			this.Color = color;
		}
		public Car(string model,Engine engine,double weight) :this(model,engine,weight,"n/a")
		{

		}
		public Car(string model,Engine engine, string color) : this(model, engine, 0, color)
		{

		}
		public Car(string model ,Engine engine) : this(model, engine,0,"n/a")
		{

		}
		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private Engine engine;

		public Engine Engine
		{
			get { return engine; }
			set { engine = value; }
		}
		
		private double weight;

		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}
		
		private string color;

		public string Color
		{
			get { return color; }
			set { color = value; }
		}


		public override string ToString()
		{
			return $"{model}\n {Engine.ToString()} Weight: {Weight}\n Color: {Color}\n";
		}
	}
}
