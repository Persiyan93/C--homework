using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_queue_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numberOfComand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<int> queue = new Queue<int>();
            int AddOperation = int.Parse(numberOfComand[0]);
            int popOperation = int.Parse(numberOfComand[1]);
            int searcedElement = int.Parse(numberOfComand[2]);
            int[] elementOfQueue = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < AddOperation; i++)
            {
                queue.Enqueue(elementOfQueue[i]);
            }
            for (int i = 0; i < popOperation; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(searcedElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count > 0)
                {


                    int minNumber = queue.Min();
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
