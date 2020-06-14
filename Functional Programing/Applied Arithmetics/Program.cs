using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string comand;
            while ((comand=Console.ReadLine())!="end")
            {
                if (comand=="add")
                {
                    numbers = numbers.Select(x => x + 1).ToList();
                }
                else if (comand=="multiply")
                {
                    numbers = numbers.Select(x => x * 2).ToList();
                }
                else if (comand=="subtract")
                {
                    numbers = numbers.Select(x => x - 1).ToList();
                }
                else if (comand=="print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
            }
        }
      
    }
    
}
