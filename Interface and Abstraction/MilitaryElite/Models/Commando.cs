using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    class Commando : ISoldier, IPrivate, ISpecialisedSoldier
    {
        public List<Mission> Missions { get; set; }
        private string corps;
        public string Corps
        {
            get
            {
                return this.corps;
            }

            set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException();
                }
                this.corps = value;
            }
        }
        public decimal Private { get ; set ; }
        public string Id { get ; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
