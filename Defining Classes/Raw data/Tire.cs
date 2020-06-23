using System;
using System.Collections.Generic;
using System.Text;

namespace Raw
{
    public class Tire
    {
        public double TirePresure { get; set; }
        public int TireAge { get; set; }
        
        public List<Tire> TireList(double tirePresure1, int tireAge1, double tirePresure2, int tireAge2, double tirePresure3, int tireAge3,
            double tirePresure4, int tireAge4)
        {
            List<Tire> tires = new List<Tire>();

            Tire tire = new Tire();
            Tire tire2 = new Tire();
            Tire tire3 = new Tire();
            Tire tire4 = new Tire();
            tire2.TirePresure = tirePresure1;
            tire2.TireAge = tireAge1;
            tires.Add(tire2);
            tire3.TirePresure = tirePresure2;
            tire3.TireAge = tireAge2;
            tires.Add(tire3);
            tire4.TirePresure = tirePresure3;
            tire4.TireAge = tireAge3;
            tires.Add(tire4);
            tire.TirePresure = tirePresure4;
            tire.TireAge = tireAge4;
            tires.Add(tire);
            return tires;


        }
    }
}
