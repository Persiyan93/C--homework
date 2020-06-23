using System;
using System.Collections.Generic;
using System.Linq;

namespace Loot_box
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>();
            Stack<int> secondBox = new Stack<int>();
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            foreach (var item in input)
            {
                firstBox.Enqueue(item);
            }
            int[] input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            foreach (var item in input2)
            {
                secondBox.Push(item);
            }
            

            List<int> result = new List<int>();
            
            while (firstBox.Count>0&&secondBox.Count>0)
            {
                if ((firstBox.Peek()+secondBox.Peek())%2==0)
                {
                    int item = firstBox.Dequeue() + secondBox.Pop();
                    result.Add(item);

                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }
            if (firstBox.Count==0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else 
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (result.Sum()>=100)
            {
                Console.WriteLine("Your loot was epic! Value: {0}", result.Sum());

            }
            else
            {
                Console.WriteLine("Your loot was poor... Value: {0}", result.Sum());
            }
        }
    }
}
