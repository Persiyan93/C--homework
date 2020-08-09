using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
   public class Pet : IBirthable
        
    {
        public Pet(string name,string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        public string Name { get; set; }
        private string birthdate;
        public string Birthdate { get =>this.birthdate; set => this.birthdate=value; }
    }
}
