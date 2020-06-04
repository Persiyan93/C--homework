using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfSets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<double> set1 = new List<double>();
            List<double> set2 = new List<double>();
            for (int i = 0; i < sizeOfSets[0]; i++)
            {
                double number = double.Parse(Console.ReadLine());
                set1.Add(number);
                
            }
            for (int i = 0; i < sizeOfSets[1]; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (set1.Contains(number))
                {
                    set2.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", set2));


        }
    }
}
