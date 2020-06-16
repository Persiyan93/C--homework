
using Define_Class_Person;
using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family myfamily = new Family();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] member = Console.ReadLine().Split(" ");
                string memberName = member[0];
                int memberAge = int.Parse(member[1]);
                Person person = new Person(memberName, memberAge);
                myfamily.AddMember(person);
            }
            Person oldestPerson= myfamily.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

           
            

        }
    }
}
