using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Basic_stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numberOfComand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<int> stack = new Stack<int>();
            int pushOperation = int.Parse(numberOfComand[0]);
            int popOperation = int.Parse(numberOfComand[1]);
            int searcedElement = int.Parse(numberOfComand[2]);
            int[] elementOfStack = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < pushOperation; i++)
            {
                stack.Push(elementOfStack[i]);
            }
            for (int i = 0; i < popOperation; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(searcedElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count>0)
                {


                    int minNumber = stack.Min();
                    Console.WriteLine(minNumber);
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
