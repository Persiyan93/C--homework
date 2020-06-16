using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Define_Class_Person
{
    public class Family
    {
       
        private List<Person> members=new List<Person>();
       

        public List<Person> Members
        {
            get { return members; }
            set { members = value; }
        }

        public void AddMember(Person person)
        {
            Members.Add(person);
        }
        public Person GetOldestMember()
        {
            Person oldestperson = new Person();
          foreach (var item in Members)
            {

                if (item.Age > oldestperson.Age)
                {
                    oldestperson = item;
                }
            }
            return oldestperson;
        }
        public List<Person> GetList(int age)
        {
            List<Person> resultList = new List<Person>();
            resultList = Members.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            return resultList;
        }
    }
}
