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
            List<int> oddList = new List<int>();
            oddList = array.Where(x => x % 2 != 0).ToList();
            oddList.Sort();
            evenList.Sort();
            foreach (var item in oddList)
            {
                evenList.Add(item);
            }

            Console.WriteLine(string.Join(" ", evenList));
        }
    }
}
