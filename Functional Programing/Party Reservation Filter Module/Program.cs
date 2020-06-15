using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;

namespace Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> filters = new List<string>();
            List<string> peoples = new List<string>();
            peoples = Console.ReadLine().Split(" ").ToList();
            string input;
            while ((input=Console.ReadLine())!="Print")
            {
                string[] comand = input.Split(";");
                if (comand[0]=="Add filter")
                {
                    filters.Add(comand[1] + ";" + comand[2]);
                }
                else
                {
                    filters.Remove(comand[1] + ";" + comand[2]);
                }
            }
            for (int i = 0; i < filters.Count; i++)
            {
                string[] currentFilter = filters[i].Split(";");
                peoples = Filter(peoples, currentFilter);
                
            }
            Console.WriteLine(string.Join(" ", peoples));
        }
        static Func<string, string, bool> Comand(string[] comand)
        {
            if (comand[0] == "Starts with")
            {
                return (x, y) => x.Substring(0, y.Length) == y;
            }
            else if (comand[0] == "Ends with")
            {

                return (x, y) => x.Substring(x.Length - y.Length, y.Length) == y;
            }
            else if(comand[0]=="Lenght")
            {
                return (x, y) => x.Length == int.Parse(y);
            }
            else
            {
                return (x, y) => x.Contains(y);
            }

        }
        static List<string> Filter(List<string> peoples, string[] comand)
        {
            Func<string, string, bool> func = Comand(comand);
            for (int i = 0; i < peoples.Count; i++)
            {
                if (func(peoples[i],comand[1]))
                {
                    peoples.RemoveAt(i);
                    i--;
                }
            }
            return peoples;
        }
    }
}
