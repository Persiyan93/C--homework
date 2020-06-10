using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
          
            Func<int[], int> MinNumber = x =>
            {
                int min = int.MaxValue;
                foreach (var item in x)
                {
                    if (item<min)
                    {
                        min = item;
                    }
                }
                return min;
            };
            Console.WriteLine(MinNumber(numbers));

        }
    }
}
