using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] locers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> barrel = new Stack<int>();
            Queue<int> locks = new Queue<int>();
            for (int i = 0; i < locers.Length; i++)
            {
                locks.Enqueue(locers[i]);
            }
            int valueOfrecept = int.Parse(Console.ReadLine());
            Reloading(bullets, barrel, sizeGunBarrel);
            int counter = 0;


            while (locks.Count != 0)
            {

                if (barrel.Count == 0)
                {
                    Console.WriteLine("Couldn't get through. Locks left: {0}", locks.Count);
                    return;
                }

                if (locks.Peek() >= barrel.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    barrel.Pop();
                    counter++;

                }
                else
                {
                    Console.WriteLine("Ping!");
                    barrel.Pop();
                    counter++;
                }


                if (sizeGunBarrel == counter && barrel.Count != 0)
                {
                    counter = 0;
                    Console.WriteLine("Reloading!");
                }
            }
            int usedBulets = bullets.Length - barrel.Count;
            int profit = valueOfrecept - (usedBulets * bulletPrice);
            Console.WriteLine("{0} bullets left. Earned ${1}", barrel.Count, profit);
        }
        static void Reloading(int[] bullets, Stack<int> barrel, int sizeOfbarrel)
        {

            for (int i = 0; i < bullets.Length; i++)
            {
                barrel.Push(bullets[i]);

            }
        }
    }
}
