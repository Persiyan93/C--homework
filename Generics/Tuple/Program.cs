using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            string fulname = $"{input[0]} {input[1]}";
           MyTuple<string,string>myTuple= new MyTuple<string,string>(fulname,input[2]);
            Console.WriteLine(myTuple.ToString());
            string[] input1 = Console.ReadLine().Split(" ");
            MyTuple<string, int> myTuple1 = new MyTuple<string, int>(input1[0], int.Parse(input1[1]));
            Console.WriteLine(myTuple1.ToString());
            string[] input2 = Console.ReadLine().Split(" ");
            MyTuple<int, double> myTuple2 = new MyTuple<int, double>(int.Parse(input2[0]),double.Parse(input2[1]));
            Console.WriteLine(myTuple2.ToString());
        }
    }
}
