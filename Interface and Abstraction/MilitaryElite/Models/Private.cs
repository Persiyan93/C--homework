using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    class Private : ISoldier, IPrivate
    {
        public Private(string id, string firsName, string lastName, string salary)
        {
            this.Id = id;
            this.FirstName = firsName;
            this.LastName = lastName;
            this.Salary = decimal.Parse(salary);
        }
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format($"Name: {0} {1} Id: {2} Salary: {3}", FirstName, LastName, Id, Salary));
            return sb.ToString();

        }
    }

}


