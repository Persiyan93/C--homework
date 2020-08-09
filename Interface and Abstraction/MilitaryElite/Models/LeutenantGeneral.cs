using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MilitaryElite.Models
{
    class LeutenantGeneral : ISoldier, ILieutenantGeneral,IPrivate
    {
        public LeutenantGeneral(string id,string firstName,string secondName,string salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = secondName;
            this.Salary = decimal.Parse(salary);
            this.Privates = new HashSet<Private>();
        }
        
        public string Id { get;  }

        public string FirstName { get;  }

        public string LastName { get;  }
        public decimal Salary { get ; set ; }

        public HashSet<Private> Privates { get; }
        public override string ToString()
        {
           StringBuilder sb=new StringBuilder
                sb.AppendLine()
        }
    }
}
