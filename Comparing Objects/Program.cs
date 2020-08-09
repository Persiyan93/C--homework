using System;
using System.Collections.Generic;

namespace Comparing_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand;
            List<Person> peoples = new List<Person>();
            while ((comand = Console.ReadLine()) != "END")
            {
                string[] input = comand.Split(" ");
                Person currentPerson = new Person(input);
             
                peoples.Add(currentPerson);
            }
            int numberofPerson = int.Parse(Console.ReadLine());
            Person person = new Person();
             person = peoples[numberofPerson - 1];
            int countOfmatches = 0;
            foreach (var item in peoples)
            {
                if (item.CompareTo(person)==0)
                {
                    countOfmatches++;
                }
            }
            if (countOfmatches!=0)
            {
                Console.WriteLine("No matches");
                return;
            }
            
            Console.WriteLine($"{countOfmatches} {peoples.Count - countOfmatches} {peoples.Count}");

        }
    }
}
