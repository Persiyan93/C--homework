using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace Santa_Present_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int>presents= new Dictionary<string, int>();
            Stack<int> material = new Stack<int>();
            Queue<int> magiclevel = new Queue<int>();
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            
            foreach (var item in input)
            {
                material.Push(item);
            }
            int[] input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            foreach (var item in input2)
            {
                magiclevel.Enqueue(item);
            }
            while (material.Count>0&&magiclevel.Count>0)
            {
                int multiplication = material.Peek() * magiclevel.Peek();
                if (multiplication<0)
                {
                    int sum = material.Pop() + magiclevel.Dequeue();
                    material.Push(sum);
                }
                else if (multiplication==0)
                {
                    if (material.Peek()==0)
                    {
                        material.Pop();
                    }
                    if (magiclevel.Peek()==0)
                    {
                        magiclevel.Dequeue();
                    }

                }
                else if (multiplication==150||multiplication==250|| multiplication == 300 || multiplication == 400)
                {
                    material.Pop();
                    magiclevel.Dequeue();
                    if (!presents.ContainsKey(Present(multiplication)))
                    {
                        presents[Present(multiplication)] = 1;
                    }
                    else
                    {
                        presents[Present(multiplication)]++;
                    }
                }
                else
                {
                    magiclevel.Dequeue();
                    material.Push(material.Pop() + 15);
                }
            }
            
            if (presents.ContainsKey("Doll")&&presents.ContainsKey("Wooden train")
                ||presents.ContainsKey("Teddy bear")&&presents.ContainsKey("Bicycle"))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            if (material.Count > 0) 
            {
                Console.Write("Materials left: ");
                Console.WriteLine(string.Join(", ", material));   
            }
            if (magiclevel.Count>0)
            {
                Console.Write("Magic left: ");
                Console.WriteLine(string.Join(", ", magiclevel));
            }
            presents = presents.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            if (presents.Count>0)
            {
                foreach (var item in presents)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
        public  static string  Present(int sum)
        {
            switch (sum)
            {
                case 150:
                    return "Doll";
                case 250:
                    return "Wooden train";
                case 300:
                    return "Teddy bear";
                case 400:
                    return "Bicycle";
                default:
                    return null;


             }
        }
        
    }
}
