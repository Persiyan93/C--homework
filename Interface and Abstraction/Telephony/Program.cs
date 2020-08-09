using System;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(" ");
            Smartphone smartphone = new Smartphone();
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                Console.WriteLine(smartphone.Call(inputNumbers[i]));
            }
            string[] inputWebsites = Console.ReadLine().Split();
            for (int i = 0; i < inputWebsites.Length; i++)
            {
                Console.WriteLine(smartphone.Browse(inputWebsites[i]));
            }
            
        }
       
    }
}
