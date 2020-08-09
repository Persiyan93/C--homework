using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
   public class Spy:ISoldier
    {
        public int CodeNumber { get; set; }

        public string Id { get; }

        public string FirstName { get; }

        public string LastName { get; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name {FirstName} {LastName} Id {Id}");
            sb.AppendLine($"Code Number: {CodeNumber}");
            return sb.ToString();
        }
    }
}
