using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
  public  class Citizen : IPerson,IBirthable,IIdentifiable
    {
        private string name;
        private int age;
        private string id;
        private string birthDate;
        public string Name { get => name; set => this.name = value; }
        public int Age
        {
            get => this.age;

            set => this.age=value;
        }
        public string Id { get =>this.id; set => this.id=value; }
        public string Birthdate { get => this.birthDate; set =>this.birthDate=value; }

        public Citizen(string name,int age,string id,string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthday;
        }
    }
}
