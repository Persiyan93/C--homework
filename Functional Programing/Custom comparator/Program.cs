using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> evenList = new List<int>();
            evenList = array.Where(x => x % 2 == 0).ToList();
            foreach (var item in array)
            {
                if (item%2!=0)
                {
                    evenList.Add(item);
                }
            }
           
            Console.WriteLine(string.Join(" ", evenList));
        }
    }
}
