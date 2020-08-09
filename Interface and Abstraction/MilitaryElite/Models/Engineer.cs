using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    class Engineer : ISoldier, IPrivate, ISpecialisedSoldier
    {
        private string corps;
        public List<Repair> ColectionOfrepaired { get; set; }
        public string Corps
        {
            get
            {
                return this.corps;
            }

            set
            {
                if (value!="Airforces"&&value!="Marines")
                {
                    throw new ArgumentException();
                }
                this.corps = value;
            }
        }
        public decimal Private { get ; set ; }
        public string Id { get ; set; }

        public string FirstName { get; }

        public string LastName { get; }
    }
}
