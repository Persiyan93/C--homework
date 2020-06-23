using System;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Box<string> input = new Box<string>();
                input.Value1 = (Console.ReadLine());
                input.ToString();
              
            }
        }
    }
}
