using System;
using System.Collections.Generic;
using System.Text;

namespace Raw
#region
{
    public class Car
    {
       
        public string Model { get; set; }
        private Engine engine=new Engine();

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        private Cargo cargo=new Cargo();

        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo=value; }
        }

        private List<Tire> tires=new List<Tire>();

        public List<Tire> Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        public Car(Engine engine,Cargo cargo)
        {

        }
        public Car(string model,int speed,int power,int weight,string type ,double tirepresure1,int tireage1, double tirepresure2, int tireage2,
            double tirepresure3, int tireage3, double tirepresure4, int tireage4)
        {
            this.Model = model;
            Engine engine = new Engine();
            this.Engine.EngineSpeed = speed;
            this.Engine.Power = power;
            this.Cargo.Cargoweight = weight;
            this.Cargo.Cargotype = type;
            this.Tires = new List<Tire>();
            Tire tire = new Tire();
            this.Tires=tire.TireList(tirepresure1, tireage1, tirepresure2, tireage2, tirepresure3, tireage3, tirepresure4, tireage4);
        }
       
    }
}
