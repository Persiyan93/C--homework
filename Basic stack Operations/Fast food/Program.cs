using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>();

            int[] inputOrders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < inputOrders.Length; i++)
            {
                orders.Enqueue(inputOrders[i]);
            }
            Console.WriteLine(orders.Max());
            int counter = orders.Count;
            for (int i = 0; i < counter; i++)
            {
                if (quantityOfFood>=orders.Peek())
                {
                    quantityOfFood =quantityOfFood- orders.Dequeue();
                    
                }
                else
                {
                    Console.Write("Orders left: ");
                    foreach (var item in orders)
                    {
                       
                        Console.Write("{0} ", item);
                        
                      
                    }
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
