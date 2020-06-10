using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Action_Point
{
    class Program
    {
        
        static void Main(string[] args)
           
       
        {
            Action<string> print = x => Console.WriteLine(x);
            string[] names = Console.ReadLine().Split(" ");
            foreach (var item in names)
            {
                print(item);
            }

        }
    }
}
