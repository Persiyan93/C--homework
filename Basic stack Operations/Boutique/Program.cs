using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int maxcapacity = int.Parse(Console.ReadLine());
            int capacity = maxcapacity;
            Stack<int> stack = new Stack<int>();
            int counter = 1;
            for (int i = 0; i < clothes.Length; i++)
            {
                stack.Push(clothes[i]);
            }
           while(stack.Count!=0)
            {
                if (capacity>=stack.Peek())
                {
                    capacity = capacity - stack.Pop();
                }
                else
                {
                    capacity = maxcapacity;
                    counter++;
                }
                        
            }
            Console.WriteLine(counter);
        }
    }
}
