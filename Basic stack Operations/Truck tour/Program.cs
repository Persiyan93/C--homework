using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_tour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int[]> stations = new Queue<int[]>();
        
            
            int numberOfStation = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStation; i++)
            {
                int[] currentStation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                stations.Enqueue(currentStation);

            }
            

            for (int i = 0; i < numberOfStation; i++)
            {
                bool flag = true;
                int reserve = 0;
                for (int j = 0; j <numberOfStation; j++)
                {
                    int[] stationParameter = stations.Peek();
                    int fuel = stationParameter[0];
                    int distance = stationParameter[1];
                    if (fuel-distance+reserve<0)
                    {
                        flag = false;

                    }
                    else
                    {
                        reserve =reserve+ fuel - distance;
                    }
                    stations.Enqueue(stations.Dequeue());
                }
                if (flag)
                {
                    Console.WriteLine(i);
                    break;
                }
                stations.Enqueue(stations.Dequeue());

                

            }
        }
    }
}
