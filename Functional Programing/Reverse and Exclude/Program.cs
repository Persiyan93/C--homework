using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());
            Func<List<int>, List<int>> reverse = x =>
            {
                List<int> reverse = new List<int>();
                for (int i = x.Count-1; i >= 0; i--)
                {
                    reverse.Add(x[i]);
                }
                return reverse;
               
            };
            numbers = reverse(numbers);
            Func<int, int, bool> selectFunv = (x, n) => x % n != 0;
            
            numbers = Mywhere(numbers, selectFunv, number);
            Console.WriteLine(string.Join(" ",numbers ));

        }
        static List<int> Mywhere(List<int> numbers,Func<int ,int, bool> func,int number)
        {
            List<int> resultList = new List<int>();
            foreach (var item in  numbers)
            {
                if (func(item, number)==true)
                {
                    resultList.Add(item);
                }
               

            }
            return resultList;
        }
    }
}
