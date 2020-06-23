using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BoxOf<string>> colection = new List<BoxOf<string>>();
           
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {

                BoxOf<string> boxOf = new BoxOf<string>();
                boxOf.Varible = (Console.ReadLine());
                colection.Add(boxOf);
            }
            int[] indexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            colection = Swap(colection, indexes);
            foreach (var item in colection)
            {
                item.ToString();
            }
        }
      public static List<T> Swap<T>(List<T>input,int[] indexes)
        {
            
            int firstIndex = indexes[0];
            int secondindex = indexes[1];
            T temp = input[firstIndex];
            input[firstIndex] = input[secondindex];
            input[secondindex] = temp;
            return input;
        }
    }
}
