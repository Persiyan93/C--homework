using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Predicate_party__
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peoples = new List<string>();
            peoples = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();



            string input;
            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] comand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (comand[0] == "Remove")
                {
                    peoples = Remove(peoples, comand);
                }
                else if (comand[0]=="Double")
                {
                    peoples = Double(peoples, comand);
                }
            }
            if (peoples.Count!=0)
            {
                Console.Write(string.Join(", ", peoples));
                Console.Write(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }
        static List<string> Double(List<string> peoples,string[] comand)
        {
            List<string> resultList = new List<string>();
            Func<string, string, bool> func = Operation(comand);
            for (int i = 0; i < peoples.Count; i++)
            {
                if (func(peoples[i], comand[2]))
                {

                    resultList.Add(peoples[i]);
                }
                resultList.Add(peoples[i]);

            }
            return resultList;

        }
        static Func<string, string, bool> Operation(string[] comand)
        {
            if (comand[1] == "StartsWith")
            {
                return (x, y) => x.Substring(0, y.Length) == y;
            }
            else if (comand[1] == "EndsWith")
            {

                return (x, y) => x.Substring(x.Length - y.Length, y.Length) == y;
            }
            else
            {
                return (x, y) => x.Length == int.Parse(y);
            }

        }
        static List<string> Remove(List<string> peoples, string[] comand)
        {
           
           
            Func<string, string, bool> func = Operation(comand);
            for (int i = 0; i < peoples.Count; i++)
            {
                if (func(peoples[i],comand[2]))
                {
                    peoples.RemoveAt(i);
                    i--;
                }

            }
            return peoples;
        }
    }
}

