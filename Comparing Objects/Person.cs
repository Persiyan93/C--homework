using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security;
using System.Text;

namespace Comparing_Objects
{
    class Person : IComparable<Person>
    {
        public Person() { }
        public Person(string[] personInfon)
        {
            this.Name = personInfon[0];
            this.Age = int.Parse(personInfon[1]);
            this.Town = personInfon[2];
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            else if (this.Age.CompareTo(other.Age) != 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            return this.Town.CompareTo(other.Town);


        }
    }
}
