using System;
using System.Linq;

namespace Date
{
    public class Date
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            DateModifier modifier = new DateModifier();
            modifier.CalculateDifference(input1, input2);
            Console.WriteLine(modifier.Difference);
           
        }
    }
}
