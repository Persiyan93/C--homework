using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            List<BoxOf<double>> colection = new List<BoxOf<double>>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                BoxOf<double> box = new BoxOf<double>();
                box.Varible = double.Parse(Console.ReadLine());
                colection.Add(box);
            }

            int counter = 0;

            double input = double.Parse(Console.ReadLine());
            foreach (var item in colection)
            {
                if (item.Compare(input))
                {
                    counter++;
                }

            }
            Console.WriteLine(counter);

        }
        


    }
}
