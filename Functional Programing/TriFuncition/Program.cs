using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace TriFuncition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ").ToList();
            Func<string, int> Charsum = x =>
            {
                int sum = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    sum =sum+ (int)x[i];
                    
                }
                return sum;

            };
            
            for (int i = 0; i < names.Count; i++)
            {
                if (Charsum(names[i])==number)
                {
                    Console.WriteLine(names[i]);
                    break;
                }
            }
        }
    }
}
