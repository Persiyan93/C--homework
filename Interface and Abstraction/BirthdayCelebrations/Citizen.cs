using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
   public class Citizen:IIdentifiable,IBirthable
    {
        public Citizen(string name,string age,string id,string birthdate)
        {
            this.Name = name;
            this.Age =int.Parse( age);
            this.Id = id;
            this.birthDate = birthdate;
        }
        public string Name { get; set; }
        public int  Age { get; set; }
        private string id;
        private string birthDate;
        public string Id { get => this.id; set => this.id=value; }
        public string Birthdate { get => this.birthDate; set => this.birthDate=value; }
    }
}
