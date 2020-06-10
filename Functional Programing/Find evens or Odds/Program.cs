using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] LimitsOfaray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string condition = Console.ReadLine();
            Func<int,bool> evenCheck = x => x % 2 == 0;
            int startIndex = LimitsOfaray[0];
            int endIndex = LimitsOfaray[1];
            List<int> list = new List<int>();
            for (int i = startIndex; i < endIndex; i++)
            {
                list.Add(i);
            }
            

            if (condition == "odd")
            {
                evenCheck = x => x % 2 != 0;
            }
            list = list.Where(evenCheck).ToList();
            Console.WriteLine(string.Join(" ", list));


        }
        
    }
}
