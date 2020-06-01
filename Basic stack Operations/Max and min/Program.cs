using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_and_min
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfcomand = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < numberOfcomand; i++)
            {
                string [] comand = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if (comand[0]=="1")
                {
                    stack.Push(int.Parse(comand[1]));
                }
                else if (comand[0]=="2")
                {
                    if (stack.Count!=0)
                    {
                        stack.Pop();
                    }
                   
                }
                else if (comand[0]=="3")
                {
                    Console.WriteLine(stack.Max());
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
              
            }
            Console.WriteLine(string.Join(", ", stack));
            
        }
    }
}
