using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastElement = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> listOfNumbers = new List<int>();
            Func<int, int, bool> checkDividing = (x, y) => x % y == 0;
            for (int i = 1; i <=lastElement; i++)
            {
                bool flag=true;
                for (int j = 0; j < dividers.Length ; j++)
                {
                    if (!checkDividing(i,dividers[j]))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    listOfNumbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
