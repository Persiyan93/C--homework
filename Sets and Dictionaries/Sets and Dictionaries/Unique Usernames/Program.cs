using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfUsernames = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();
            for (int i = 0; i < numberOfUsernames; i++)
            {
                string name = Console.ReadLine();
                usernames.Add(name);
            }
            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
