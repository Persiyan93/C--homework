using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesLenght = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Func<int, string, bool> check = (x, names) => x >= names.Length;
            foreach (var item in names)
            {
                if (check(namesLenght,item))
                {
                    Console.WriteLine(item);
                }
            }


        }
        


    }
}
