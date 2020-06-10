using System;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<string> SirAppend = x => Console.WriteLine("Sir " + x);
            
            string[] names = Console.ReadLine().Split(" ");
            foreach (var item in names)
            {
                SirAppend(item);
            }
            
            
        }
    }
}
