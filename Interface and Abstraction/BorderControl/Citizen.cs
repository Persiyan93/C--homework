using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
   public class Citizen:IIdentifiable,IBirthable,IBuyer
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
        private int food;
        public string Id { get => this.id; set => this.id=value; }
        public string Birthdate { get => this.birthDate; set => this.birthDate=value; }
        public int Food { get => this.food; set => this.food=value; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
