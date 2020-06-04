using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            SortedSet<string> elemnts = new SortedSet<string>();
            for (int i = 0; i < countOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in input)
                {
                    elemnts.Add(item);
                }

            }
            Console.WriteLine(string.Join(" ", elemnts));
        }
        
    }
}
